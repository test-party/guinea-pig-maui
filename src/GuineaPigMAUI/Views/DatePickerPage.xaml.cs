namespace GuineaPigMAUI
{
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
            
            // Set the default date to today
            MyDatePicker.Date = DateTime.Now;
        }
    }
}