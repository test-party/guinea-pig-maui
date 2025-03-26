namespace GuineaPigMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnOpenButtonScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ButtonPage());
	}
}

