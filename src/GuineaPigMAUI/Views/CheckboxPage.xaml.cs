namespace GuineaPigMAUI
{
    public partial class CheckboxPage : ContentPage
    {
        private bool isChecked = false;
        private bool isUnchecked = true;

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsUnchecked
        {
            get => isUnchecked;
            set
            {
                if (isUnchecked != value)
                {
                    isUnchecked = value;
                    OnPropertyChanged();
                }
            }
        }

        public CheckboxPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnValidCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = e.Value;
        }

        private void OnValidUncheckedCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            IsUnchecked = e.Value;
        }

        private void OnNoLabelCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = e.Value;
        }

        private void OnDuplicateLabelCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = e.Value;
        }
    }
}