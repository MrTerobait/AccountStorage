using AccountStorage.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace AccountStorage.ViewModels
{
    public class AccountListDictionaryVM
    {        
        public Dictionary<string, BindingList<Account>> AccountListDictionary;
        public BindingList<Account> NamelessAccountList { get; }
        public BindingList<Account> Basket { get; }
        private AccountListVM ChosenAccountList { get; }
        public AccountListDictionaryVM()
        {

        }
    }
}
