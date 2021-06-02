using System;
using System.Collections.ObjectModel;

namespace AccountStorage.Models
{
    public class Account
    {
        public string Description { get; set; }
        public string Login { get; set; }
        public ObservableCollection<string> Links { get; set; }
        private string _password;
        public string Password
        { 
            get { return _password; } 
            set 
            {
                _password = value;
                LastPasswordUpdate = DateTime.Now;
            } 
        }
        public DateTime LastPasswordUpdate { get; private set; }
    }
}
