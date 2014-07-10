namespace XamlMvvmBasic
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    
    public class Person
        : INotifyPropertyChanged
    {
        private String firstName;

        private String lastName;

        public event PropertyChangedEventHandler PropertyChanged;

        public String FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(@"Name");
            }
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(@"Name");
            }
        }

        public String Name
        {
            get
            {
                return 
                    String.Format(
                        @"{0} {1}", 
                        this.firstName, 
                        this.lastName);
            }
        }
        
        protected virtual void OnPropertyChanged(
            [CallerMemberName] String propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}