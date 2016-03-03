using Caliburn.Addins.Commands;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caliburn.Addins {
    /// <summary>
    /// 命令帮助类，用来从ViewModel绑定命令到View，同时支持RoutedUICommand的绑定
    /// </summary>
    public static class CommandHelper {

        /// <summary>
        /// 将RoutedUICommand绑定到View
        /// </summary>
        /// <param name="screen"></param>
        /// <param name="command"></param>
        /// <param name="excuted"></param>
        /// <param name="canExcute"></param>
        public static void BindCommand(this Screen screen,RoutedUICommand command, ExecutedRoutedEventHandler excuted,CanExecuteRoutedEventHandler canExcute) {
            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);

            if (viewType != null) {
                CommandManager.RegisterClassCommandBinding(viewType, new CommandBinding(command,excuted,canExcute));
            }

        }

        public static void BindCommand(this Screen screen, RoutedUICommand command, ExecutedRoutedEventHandler excuted) {
            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);

            if (viewType != null) {
                CommandManager.RegisterClassCommandBinding(viewType, new CommandBinding(command, excuted));
            }
        }


        /// <summary>
        /// 将RoutedUICommand绑定到View同时支持直接指定excuted和canexcuted方法
        /// </summary>
        /// <param name="screen"></param>
        /// <param name="command"></param>
        /// <param name="excuted"></param>
        /// <param name="canExcuted"></param>
        public static void BindCommand(this Screen screen,RoutedUICommand command,Action<object> excuted,Func<object,bool> canExcuted) {

            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);

            if (viewType != null) {
                CommandManager.RegisterClassCommandBinding(
                    viewType,
                    new CommandBinding(
                        command,
                        (sender, e) => excuted(e.Parameter),
                        (sender, e) => e.CanExecute = canExcuted(e.Parameter)));
            }

        }

        public static void BindCommand(this Screen screen, RoutedUICommand command, Action<object> excuted) {

            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);

            if (viewType != null) {
                CommandManager.RegisterClassCommandBinding(
                    viewType,
                    new CommandBinding(
                        command,
                        (sender, e) => excuted(e.Parameter)));
            }

        }

        public static void BindHotKey(this Screen screen,ICommand command,Key key,ModifierKeys modifiers) {
            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);

            if (viewType != null) {
                CommandManager.RegisterClassInputBinding(viewType, new KeyBinding(command,key, modifiers));
            }
        }

        public static void BindHotKey(this Screen screen,IAppCommand command,Key key,ModifierKeys modifiers)
        {
            Type viewType = ViewLocator.LocateTypeForModelType(screen.GetType(), null, null);
            if (viewType != null)
            {
                CommandManager.RegisterClassInputBinding(viewType, new KeyBinding(command, key, modifiers));
                command.HotKey = new KeyGesture(key, modifiers);
            }
        }

    }
}
