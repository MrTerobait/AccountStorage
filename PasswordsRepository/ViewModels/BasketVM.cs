using AccountStorage.Models;
using AccountStorage.ViewModels.BaseTypes;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class BasketVM
    {
        public ObservableCollection<Account> BasketList { get; set; }
        public ICommand AddDeletedAccountCommand { get => new Command(AddDeletedAccount); }
        private void AddDeletedAccount(object parameter)
        {
            BasketList.Add(new Account() { Description = $"{BasketList.Count + 1}" });
        }

        public BasketVM()
        {
            BasketList = new ObservableCollection<Account>() { new Account() { Description = "почта terobite.vladimr@mail.ru" } };
        }
    }
}
