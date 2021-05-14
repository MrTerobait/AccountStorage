using System;

namespace AccountStorage.Models
{

    public class Account
    {
        public string Description { get; set; }
        public string Login { get; set; }
        public string Link { get; set; }
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
