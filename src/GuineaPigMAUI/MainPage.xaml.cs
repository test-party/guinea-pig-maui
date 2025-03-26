namespace GuineaPigMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnOpenButtonScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ButtonPage());
	}

	private async void OnOpenCheckboxScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CheckboxPage());
	}

	private async void OnOpenImageScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ImagePage());
	}
}

