using AccountStorage.Commands;
using AccountStorage.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public delegate void AccountRemovedHandler(object sender, Account removedAccount);
    public class AccountListVM : UserControlVM
    {
        private Account selectedAccount;
        public Account SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                if (AccountList.Contains(value) || value == null)
                    selectedAccount = value;
                else throw new Exception("Account doesn't exist in the account list");
            }
        }
        public BindingList<Account> AccountList { get; set; }

        public ICommand AddAccountCommand { get => new DelegateCommand(AddAccount); }
        private void AddAccount(object p)
        {
            AccountList.Add(new Account() { Description = $"{AccountList.Count + 1}" });
        }

        public ICommand RemoveAccountCommand { get => new DelegateCommand(RemoveAccount); }

        public event AccountRemovedHandler AccountRemoved;
        private void RemoveAccount(object isNotify)
        {
            AccountList.Remove(SelectedAccount);
            if ((bool)isNotify)
            {
                AccountRemoved?.Invoke(this, SelectedAccount);
            }
            SelectedAccount = null;
        }

        public ICommand ClearAccountListCommand { get => new DelegateCommand(ClearAccountList); }
        private void ClearAccountList(object p)
        {
            AccountList.Clear();
        }
        public AccountListVM(BindingList<Account> accountList)
        {
            AccountList = accountList;
        }
    }
}
