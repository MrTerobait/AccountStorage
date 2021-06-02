using AccountStorage.Models;
using AccountStorage.ViewModels.BaseTypes;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class AccountListVM
    {
        public ObservableCollection<Account> AccountList { get; set; }
        public ICommand AddAccountCommand { get => new Command(AddAccount); }
        private void AddAccount(object p)
        {
            AccountList.Add(new Account() { Description = $"{AccountList.Count + 1}" });
        }
        public ICommand GoToEntranceAccountCommand { get => new Command(GoToEntranceAccount); }
        private void GoToEntranceAccount(object p)
        {

        }

        public AccountListVM()
        {
            AccountList = new ObservableCollection<Account>() { new Account() { Description = "почта terobite.vladimr@mail.ru" } };
        }
    }
}
