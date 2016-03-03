using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Caliburn.Addins.Commands
{
    /// <summary>
    /// 应用程序命令基类
    /// </summary>
    public abstract class AppCommandBase : IAppCommand
    {
        public KeyGesture HotKey{get;set;}

        public string HotKeyText
        {
            get
            {
                return HotKey==null?"":GetHotKeyText(HotKey.Key,HotKey.Modifiers);
            }
        }

        public string Icon { get; set; }

        public bool IsCheckable { get; set;  }

        public bool IsChecked { get; set; }


        public string Name { get;  set; }

        public string ToolTip { get;  set; }
        /// <summary>
        /// 默认已经创建了一个空的集合
        /// </summary>
        public ObservableCollection<IAppCommand> Items { get; } = new ObservableCollection<IAppCommand>();

        public bool IsVisible { get; set; }

        public Type Owner { get; set; }

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


        public static string GetHotKeyText(Key key,ModifierKeys modifiers)
        {
            string modifiersName;
            string format = "{0}+{1}";
            switch (modifiers)
            {
                case ModifierKeys.Control:
                    modifiersName = "Ctrl";
                    break;
                case ModifierKeys.Windows:
                    modifiersName = "Win";
                    break;
                default:
                    modifiersName = Enum.GetName(modifiers.GetType(), modifiers);
                    break;
            }

            return string.Format(format, modifiersName, Enum.GetName(key.GetType(), key));
        }

        public void OnAttach()
        {
           
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, HotKeyText);
        }
    }



}
