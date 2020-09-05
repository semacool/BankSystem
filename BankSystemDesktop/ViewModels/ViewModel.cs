using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
