using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Input;
using Caliburn.Micro;

namespace Caliburn.Addins.Commands {
    /// <summary>
    /// 命令服务器，聚合管理所有的命令和快捷键管理
    /// </summary>
    /// <typeparam name="TMainView">主窗口类型</typeparam>
    public class CommandService<TMainViewModel> : IPartImportsSatisfiedNotification, ICommandService {
        /// <summary>
        /// 导入所有命令
        /// </summary>
        [ImportMany]
        public IEnumerable<IAppCommand> Commands { get; set; }

        /// <summary>
        /// 导入成功后会调用这个方法，在这个方法里做一些处理例如绑定快捷键
        /// </summary>
        public void OnImportsSatisfied() {
            //初始化所有快捷键绑定
            foreach(IAppCommand command in Commands) {
                var hotkey = command.GetType().GetCustomAttribute<HotKeyAttribute>();
                if (hotkey != null) {
                    command.HotKeyText = HotKeyTextConverter.GetText(hotkey.Key, hotkey.Modifiers);
                    if (hotkey.OwnerView == null) {
                        Type viewType = ViewLocator.LocateTypeForModelType(typeof(TMainViewModel), null, null);
                        CommandManager.RegisterClassInputBinding(viewType, new KeyBinding(command, hotkey.Key, hotkey.Modifiers));
                    }
                    else {
                        CommandManager.RegisterClassInputBinding(hotkey.OwnerView, new KeyBinding(command, hotkey.Key, hotkey.Modifiers));
                    }
                }
            }

            //初始化菜单模型

            //初始化上下文菜单模型

        }
    }

    public static class HotKeyTextConverter {
        public static string GetText(Key key,ModifierKeys modifiers) {
                string text = string.Format("{0}+{1}", GetShortName(modifiers), key);
                return text;
        }

        public static string GetShortName(ModifierKeys modifiers) {
            switch (modifiers) {
                case ModifierKeys.Control:
                    return "Ctrl";
                case ModifierKeys.Windows:
                    return "Win";
                default:
                    return Enum.GetName(modifiers.GetType(),modifiers);
            }
        }
    }
 
}
