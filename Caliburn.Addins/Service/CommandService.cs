using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Input;
using Caliburn.Micro;
using Caliburn.Addins.WorkBench;
using System.Collections.ObjectModel;
using System.Windows;

namespace Caliburn.Addins.Commands {
    /// <summary>
    /// 命令服务器，聚合管理所有的命令和快捷键管理
    /// </summary>
    /// <typeparam name="TMainView">主窗口类型</typeparam>
    public class CommandService: ICommandService {
        /// <summary>
        /// 导入所有命令
        /// </summary>
        [ImportMany]
        public ObservableCollection<IAppCommand> Commands { get; set; }

        public Dictionary<string,ObservableCollection<IAppCommand>> Menus { get; set; }

        public Dictionary<string, ObservableCollection<IAppCommand>> ContextMenus { get; set; }

        public CommandService()
        {
            Application.Current.Activated += Current_Activated;
        }

        private void Current_Activated(object sender, EventArgs e)
        {
            Configure();
        }

        public void Configure()
        {
            //初始化所有快捷键绑定
            foreach (IAppCommand command in Commands)
            {
                var hotkey = command.HotKey;
                if (hotkey != null)
                {
                    if (command.Owner == null)
                    {
                        Type viewType = Application.Current.MainWindow.GetType();
                        CommandManager.RegisterClassInputBinding(viewType, new KeyBinding(command, hotkey.Key, hotkey.Modifiers));
                    }
                    else {
                        CommandManager.RegisterClassInputBinding(command.Owner, new KeyBinding(command, hotkey.Key,  hotkey.Modifiers));
                    }
                }
            }
        }

    }

 
}
