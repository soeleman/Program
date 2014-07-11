namespace XamlMvvmBasic
{
    using System;
    using System.Windows.Input;

    public class DelegateCommand 
        : ICommand
    {
        private readonly Action actionExecute;

        private readonly Func<Boolean> funcCanExecute;

        public DelegateCommand(
            Action execute)
            : this(execute, () => true)
        {
        }

        public DelegateCommand(
            Action execute, 
            Func<Boolean> canexecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException(@"execute");
            }

            actionExecute  = execute;
            funcCanExecute = canexecute;
        }

        public event EventHandler CanExecuteChanged;
        
        public void Execute(
            Object p)
        {
            if (this.CanExecute(null))
            {
                this.actionExecute();
            }
        }

        public Boolean CanExecute(
            Object p)
        {
            return this.funcCanExecute == null || this.funcCanExecute();
        }

        public void RaiseCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}