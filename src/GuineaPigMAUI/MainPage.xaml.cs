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

	private async void OnOpenDatePickerScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DatePickerPage());
	}

	private async void OnOpenImageScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ImagePage());
	}

	private async void OnOpenLinkScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new LinkPage());
	}

	private async void OnOpenProgressIndicatorScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ProgressIndicatorPage());
	}
	
	private async void OnOpenSheetScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SheetPage());
	}
	
	private async void OnOpenStepperScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new StepperPage());
	}

	private async void OnOpenTextInputScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TextInputPage());
	}

	private async void OnOpenTextScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TextPage());
	}
	private async void OnOpenVideoScreenClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new VideoPage());
	}
}

