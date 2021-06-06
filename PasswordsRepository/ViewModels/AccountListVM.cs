using AccountStorage.Models;
using AccountStorage.ViewModels.BaseTypes;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class AccountListVM
    {
        public string Name { get; set; }
        private Account selectedAccount;
        public Account SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                if (AccountList.Contains(value))
                    selectedAccount = value;
                else throw new Exception("Account doesn't exist in the account list");
            }
        }
        public BindingList<Account> AccountList { get; }
        public ICommand AddAccountCommand { get => new Command(AddAccount); }
        private void AddAccount(object p)
        {
            AccountList.Add(new Account() { Description = $"{AccountList.Count + 1}" });
        }
        public ICommand DeleteAccountCommand { get => new Command(DeleteAccount); }
        private void DeleteAccount(object p)
        {
            var acc = p as Account;
            AccountList.Remove(acc);
        }
        public ICommand RemoveAccountCommand { get => new Command(RemoveAccount); }
        private void RemoveAccount(object p)
        {
            if (AccountList.Remove(SelectedAccount))
            {
                AccountSended?.Invoke(this, SelectedAccount);
                SelectedAccount = null;
            }
        }
        public event Action<object, Account> AccountSended;
        public ICommand DeleteAccountsCommand { get => new Command(DeleteAccounts); }
        private void DeleteAccounts(object p)
        {
            AccountList.Clear();
        }
        public AccountListVM(BindingList<Account> accounts)
        {
            AccountList = accounts;
        }
    }
}
