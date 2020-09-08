using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace LovesTestGitHub
{
    class ViewModel:INotifyPropertyChanged
    {
        public string InPut { get; set; }
        public string OutPut { get; set; }
        public ICommand ButtonCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InputToOutput()
        {
            OutPut = InPut;
        }

        public ViewModel()
        {
            ButtonCommand = new RelayCommand(InputToOutput);
        }
    }
}
