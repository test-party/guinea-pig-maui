using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GuineaPigMAUI
{
    public partial class TextInputPage : ContentPage, INotifyPropertyChanged
    {
        private string _field1Value = string.Empty;
        private string _field2Value = string.Empty;
        private string _field3Value = string.Empty;
        private string _field4Value = string.Empty;

        public string Field1Value
        {
            get => _field1Value;
            set
            {
                if (_field1Value != value)
                {
                    _field1Value = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Field2Value
        {
            get => _field2Value;
            set
            {
                if (_field2Value != value)
                {
                    _field2Value = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Field3Value
        {
            get => _field3Value;
            set
            {
                if (_field3Value != value)
                {
                    _field3Value = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Field4Value
        {
            get => _field4Value;
            set
            {
                if (_field4Value != value)
                {
                    _field4Value = value;
                    OnPropertyChanged();
                }
            }
        }

        public TextInputPage()
        {
            InitializeComponent();
            BindingContext = this;

            // Set up bindings
            Field1.BindingContext = this;
            Field1.SetBinding(Entry.TextProperty, nameof(Field1Value));

            Field2.BindingContext = this;
            Field2.SetBinding(Entry.TextProperty, nameof(Field2Value));

            Field3.BindingContext = this;
            Field3.SetBinding(Entry.TextProperty, nameof(Field3Value));

            Field4.BindingContext = this;
            Field4.SetBinding(Entry.TextProperty, nameof(Field4Value));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}