using AccountStorage.Commands;
using AccountStorage.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class MainWindowVM : BaseVM
    {
        #region WindowState
        private WindowState _windowState = WindowState.Maximized;
        public WindowState WindowState
        {
            get { return _windowState; }
            set
            {
                _windowState = value;
                OnPropertyChanged(nameof(WindowState));
            }
        }
        public ICommand CloseAppCommand => new DelegateCommand((p) => App.Current.Shutdown());
        public ICommand SetWindowStateToMinimizedCommand => new DelegateCommand((p) => WindowState = WindowState.Minimized);      
        public ICommand SetWindowStateToMaximizedCommand => new DelegateCommand((p) => WindowState = WindowState.Maximized);
        public ICommand SetWindowStateToNormalCommand => new DelegateCommand((p) => WindowState = WindowState.Normal);
        #endregion

        public UserControlVM AccountList { get; }
        public Visibility AccountListVisibility
        {
            get
            {
                if (Setters.Visibility == Visibility.Visible)
                {
                    return Visibility.Collapsed;
                }
                return AccountList.Visibility; 
            }
            set { AccountList.Visibility = value; }
        }

        public UserControlVM Basket { get; }
        public Visibility BasketVisibility
        {
            get
            {
                if (Setters.Visibility == Visibility.Visible)
                {
                    return Visibility.Collapsed;
                }
                return Basket.Visibility; 
            }
            set { Basket.Visibility = value; }
        }

        public UserControlVM PasswordGenerator { get; }
        public Visibility PasswordGeneratorVisibility
        {
            get 
            {
                if (Setters.Visibility == Visibility.Visible)
                {
                    return Visibility.Collapsed;
                }
                return PasswordGenerator.Visibility; 
            }
            set { PasswordGenerator.Visibility = value; }
        }

        public UserControlVM Setters { get; }
        public Visibility SettersVisibility
        {
            get { return Setters.Visibility; }
            set { Setters.Visibility = value; }
        }

        public MainWindowVM()
        {
            AccountList = new AccountListVM(new BindingList<Account>() { new Account() { Description = "terobite.vladimr@mail.ru" } });
            AccountListVisibility = Visibility.Visible;
            Basket = new AccountListVM(new BindingList<Account>() { new Account() { Description = "deleted@mail.ru" } });
            BasketVisibility = Visibility.Collapsed;
            PasswordGenerator = new PasswordGeneratorVM();
            PasswordGenerator.Visibility = Visibility.Collapsed;
            Setters = new SettersVM();
            Setters.Visibility = Visibility.Collapsed;
        }
    }
}
