using System;
using System.Windows.Input;

namespace AccountStorage.ViewModels.BaseTypes
{
    public class Command : ICommand
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
