using AccountStorage.Models;
using System.Collections.Generic;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AccountStorage
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string Property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }

        private List<Account> accounts = new List<Account>();

        public ICommand SetAccountListUC { get; }
        public MainWindowViewModel()
        {
        }

    }
}
