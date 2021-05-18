using AccountStorage.Models;
using AccountStorage.ViewModels.BaseTypes;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class AccountListVM
    {
        public ObservableCollection<Account> Accounts { get; }
        public ICommand AddAccountCommand { get; }
        private void OnAddAccountCommandExecuted(object p)
        {
            Accounts.Add(new Account() { Description = "Почта какая-то" });
        }

        public AccountListVM()
        {
            Accounts = new ObservableCollection<Account>() { new Account() { Description = "Почта terobite.vladimr@mail.ru" } };
            AddAccountCommand = new Command(OnAddAccountCommandExecuted);
        }
    }
}
