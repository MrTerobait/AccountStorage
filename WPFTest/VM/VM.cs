using AccountStorage.Commands;
using AccountStorage.ViewModels;
using System.Windows.Input;

namespace WPFTest.VM
{
    public class VM : BaseVM
    {
        private string title;

        public string Title
        {
            get { return title; }
            set 
            { 
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ICommand ChangeTitleCommand => new DelegateCommand((p) => Title = p as string);
    }
}
