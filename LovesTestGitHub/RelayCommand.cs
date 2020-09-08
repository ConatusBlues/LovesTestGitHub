using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LovesTestGitHub
{
    class RelayCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action action;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {    
            action();
        }

        public RelayCommand(Action action)
        {
            this.action = action;
        }


    }
}
