using AccountStorage.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace AccountStorage
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Account> Accounts { get; }

        public ICommand AddAccountCommand { get; }
        private void OnAddAccountCommandExecuted(object p)
        {
            Accounts.Add(new Account() { Description = "Почта какая-то" } );
        }

        public MainWindowViewModel()
        {
            Accounts = new ObservableCollection<Account>() { new Account() { Description = "Почта terobite.vladimr@mail.ru"} };
            AddAccountCommand = new Command(OnAddAccountCommandExecuted);
        }

    }
}
