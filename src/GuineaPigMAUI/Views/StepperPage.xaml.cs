namespace GuineaPigMAUI
{
    public partial class StepperPage : ContentPage
    {
        public StepperPage()
        {
            InitializeComponent();
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Update the label with the current stepper value
            ValueLabel.Text = $"{e.NewValue}";
        }
    }
}