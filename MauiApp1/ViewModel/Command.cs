//using Android.Service.Controls.Actions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    internal class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action _viewModelAction;

        public Command(Action viewModelAction)
        {
            _viewModelAction = viewModelAction;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _viewModelAction();
        }
    }
}
