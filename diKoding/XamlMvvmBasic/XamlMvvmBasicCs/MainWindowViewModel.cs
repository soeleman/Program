namespace XamlMvvmBasic
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class MainWindowViewModel
        : INotifyPropertyChanged
    {
        private Person model;

        public MainWindowViewModel()
        {
            this.model = 
                new Person
                    {
                        FirstName = @"John", 
                        LastName  = @"Doe"
                    };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Person Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged(
            [CallerMemberName] String propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(
                    this, 
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}