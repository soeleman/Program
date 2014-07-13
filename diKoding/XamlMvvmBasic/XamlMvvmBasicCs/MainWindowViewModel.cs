namespace XamlMvvmBasic
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Input;

    public class MainWindowViewModel
        : INotifyPropertyChanged
    {
        private Person model;
        private ICommand clickCommand;

        public MainWindowViewModel()
            : this(DesignerProperties.GetIsInDesignMode(new DependencyObject())
                    ? (IDataService)new DataServiceInDesign()
                    : new DataService())
        {
        }

        public MainWindowViewModel(
            IDataService dataService)
        {
            var personData = 
                dataService.GetPerson();

            this.model =
                new Person
                {
                    FirstName = personData.FirstName,
                    LastName  = personData.LastName
                };

            this.clickCommand =
                new DelegateCommand(() =>
                    this.model.LastName = String.Format(@"{0} *", this.model.LastName));
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

        public ICommand ClickCommand
        {
            get
            {
                return this.clickCommand;
            }

            set
            {
                this.clickCommand = value;
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