using CommunityToolkit.Maui.Views;

namespace GuineaPigMAUI
{
    public partial class SheetPage : ContentPage
    {
        public SheetPage()
        {
            InitializeComponent();
        }

        private void OnShowFailBottomSheetClicked(object sender, EventArgs e)
        {
            var popup = new BottomSheetPopup
            {
                Message = "Awesome 🎉",
                HasScrollView = false
            };

            this.ShowPopup(popup);
        }

        private void OnShowPassBottomSheetClicked(object sender, EventArgs e)
        {
            var popup = new BottomSheetPopup
            {
                Message = "Awesome 🎉",
                HasScrollView = true
            };

            this.ShowPopup(popup);
        }
    }

    public class BottomSheetPopup : Popup
    {
        public string Message { get; set; }
        public bool HasScrollView { get; set; }
        private Label messageLabel;

        public BottomSheetPopup()
        {
            // Get the screen width for sizing
            double screenWidth = Application.Current.MainPage.Width;
            if (screenWidth <= 0)
                screenWidth = 300; // Fallback width

            Size = new Size(screenWidth, 300);
            VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
            Color = Colors.White;

            // Create content immediately instead of waiting for Opened event
            InitializeContent();
        }

        private void InitializeContent()
        {
            messageLabel = new Label
            {
                Text = Message ?? "Awesome 🎉", // Provide a default if null
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 16
            };

            VerticalStackLayout layout = new VerticalStackLayout
            {
                Padding = new Thickness(36),
                HorizontalOptions = LayoutOptions.Center
            };

            if (HasScrollView)
            {
                ScrollView scrollView = new ScrollView
                {
                    Content = messageLabel
                };
                layout.Children.Add(scrollView);
            }
            else
            {
                layout.Children.Add(messageLabel);
            }

            Frame frame = new Frame
            {
                Content = layout,
                CornerRadius = 20,
                BorderColor = Colors.Transparent,
                HasShadow = true
            };

            Content = frame;
        }

        // Update the message if it changes after initialization
        public void UpdateMessage()
        {
            if (messageLabel != null)
                messageLabel.Text = Message ?? "Awesome 🎉";
        }
    }

}