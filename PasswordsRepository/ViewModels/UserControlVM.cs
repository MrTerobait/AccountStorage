using AccountStorage.Commands;
using System.Windows;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class UserControlVM : BaseVM
    {
        private Visibility _visibility;
        public Visibility Visibility 
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        public ICommand SetVisibilityToVisible => new DelegateCommand((p) => Visibility = Visibility.Visible);
        public ICommand SetVisibilityToCollapsed => new DelegateCommand((p) => Visibility = Visibility.Collapsed);
    }
}
