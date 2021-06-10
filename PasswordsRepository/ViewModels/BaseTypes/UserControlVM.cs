using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace AccountStorage.ViewModels.BaseTypes
{
    public abstract class UserControlVM : INotifyPropertyChanged
    {
        public Visibility Visibility
        {
            get
            {
                return Visibility;
            }
            set
            {
                Visibility = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Visibility"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
