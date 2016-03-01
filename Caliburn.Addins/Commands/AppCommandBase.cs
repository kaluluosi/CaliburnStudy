using System;
using System.Windows.Input;

namespace Caliburn.Addins.Commands {
    public abstract class AppCommandBase : IAppCommand {
        public string HotKeyText
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Text
        {
            get; set;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
