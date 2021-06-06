using AccountStorage.Models;
using System.ComponentModel;

namespace AccountStorage.ViewModels
{
    public class MainVM
    {
       public AccountListVM AccountListVM { get; }
       public BasketVM BasketVM { get; }
        public MainVM()
        {
            AccountListVM = new AccountListVM(new BindingList<Account>() { new Account() { Description = "terobite.vladimr@mail.ru" } });;
            BasketVM = new BasketVM();
        }
    }
}
