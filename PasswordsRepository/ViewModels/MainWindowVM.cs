using AccountStorage.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountStorage.ViewModels
{
    public class MainWindowVM
    {
        public ObservableCollection<Account> AccountList { get; set; }
        public ICommand AddAccountCommand { get => new Command(AddAccount); }
        private void AddAccount(object parameter)
        {
            AccountList.Add(new Account() { Description = $"{AccountList.Count+1}" });
        }

        public MainWindowVM()
        {
            AccountList = new ObservableCollection<Account>() { new Account() { Description = "почта terobite.vladimr@mail.ru" } };
            
        }
        private class Command : ICommand
        {
            private readonly Action<object> _execute;
            private readonly Func<object, bool> _canExecute;

            public event EventHandler CanExecuteChanged
            {
                add => CommandManager.RequerySuggested += value;
                remove => CommandManager.RequerySuggested -= value;
            }

            public void Execute(object parameter) => _execute.Invoke(parameter);
            public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

            public Command(Action<object> execute, Func<object, bool> canExecute = null)
            {
                _execute = execute;
                _canExecute = canExecute;
            }
        }
    }
}
