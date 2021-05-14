using AccountStorage.Models;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace AccountStorage
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Account> Accounts { get; }

        public ICommand AddAccountCommand { get; }
        private void OnAddAccountCommandExecuted(object p)
        {
            Accounts.Add(new Account());
        }

        public MainWindowViewModel()
        {
            Accounts = new ObservableCollection<Account>() { new Account() };
            AddAccountCommand = new Command(OnAddAccountCommandExecuted);
        }

    }
}
