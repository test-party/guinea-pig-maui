using System.Windows.Input;

namespace GuineaPigMAUI.ViewModels
{
    public class LinkViewModel
    {
        public ICommand NavigateToHomeCommand { get; }
        public ICommand OpenExternalLinkCommand { get; }

        public LinkViewModel()
        {
            NavigateToHomeCommand = new Command(NavigateToHome);
            OpenExternalLinkCommand = new Command(OpenExternalLink);
        }

        private async void NavigateToHome()
        {
            // Navigate to home page
            await Shell.Current.GoToAsync("//MainPage");
        }

        private async void OpenExternalLink()
        {
            // Open external URL
            try
            {
                await Browser.Default.OpenAsync("https://dotnet.microsoft.com/apps/maui", 
                    BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // Handle any exceptions, for example by showing an alert
                await Shell.Current.DisplayAlert("Error", 
                    $"Unable to open link: {ex.Message}", "OK");
            }
        }
    }
}