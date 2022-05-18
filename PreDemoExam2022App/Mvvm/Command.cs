using System;
using System.Windows.Input;

namespace PreDemoExam2022App.Mvvm
{
    internal class Command<T> : ICommand
    {
        private readonly Action<T>? _execute;
        private readonly Predicate<T>? _canExecute;

        public Command(Action<T>? execute, Predicate<T>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged 
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute((T) parameter);
        }

        public void Execute(object? parameter)
        {
            _execute?.Invoke((T) parameter);
        }
    }
}
