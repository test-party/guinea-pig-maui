using System.Windows.Input;

namespace GuineaPigMAUI
{
    public partial class LinkPage : ContentPage
    {
        public ICommand NavigateToHomeCommand { get; private set; }
        public ICommand OpenExternalLinkCommand { get; private set; }

        public LinkPage()
        {
            InitializeComponent();
            
            NavigateToHomeCommand = new Command(async () => await NavigateToHome());
            OpenExternalLinkCommand = new Command(async () => await OpenExternalLink());
            
            BindingContext = this;
        }

        private async Task NavigateToHome()
        {
            // Navigate to home page
            await Shell.Current.GoToAsync("///MainPage");
        }

        private async Task OpenExternalLink()
        {
            // Open an external link
            // For this example, we'll open the browser to a placeholder URL
            await Launcher.OpenAsync(new Uri("https://dotnet.microsoft.com/en-us/apps/maui"));
        }
    }
}