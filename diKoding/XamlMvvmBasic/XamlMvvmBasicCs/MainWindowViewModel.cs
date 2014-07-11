namespace XamlMvvmBasic
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows;

    public class MainWindowViewModel
        : INotifyPropertyChanged
    {
        private Person model;

        public MainWindowViewModel()
        {
            var personData = 
                DesignerProperties.GetIsInDesignMode(new DependencyObject())
                    ? new DataServiceInDesign().GetPerson()
                    : new DataService().GetPerson();

            this.model = 
                new Person
                    {
                        FirstName = personData.FirstName, 
                        LastName  = personData.LastName
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