using Caliburn.Addins.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Service
{
    public class MenuManager : IPartImportsSatisfiedNotification, IMenuManager
    {
        [ImportMany]
        protected ObservableCollection<IAppCommand> Commands { get; set; }

        private Func<IAppCommand, string> MenuPath = (c) => c.GetType().GetCustomAttribute<MenuPathAttribute>().Path;

        /// <summary>
        /// 上下文字典用来检索对应ViewModel的上下文菜单
        /// </summary>
        public ObservableCollection<IAppCommand> Menus { get; protected set; } = new ObservableCollection<IAppCommand>();

        public void OnImportsSatisfied()
        {
            //过滤出菜单命令
            var menuCommands = Commands.Where(c => c.GetType().GetCustomAttribute<MenuPathAttribute>() != null).Select(c=>c );

            //将命令组装成菜单
            foreach(var command in menuCommands)
            {
                string[] phases = MenuPath(command).Split('.');
                Locate(phases, Menus).Items.Add(command);
            }

        }

        private IAppCommand Locate(string[] phases,ObservableCollection<IAppCommand> commands)
        {
            string phase = phases[0];
            IAppCommand command = commands.FirstOrDefault(c => c.Name == phase);
            if (command != null)
                return command;

            IAppCommand newCommand = new EmptyCommand() { Name = phase };
            commands.Add(newCommand);
            if (phases.Length == 1) return newCommand;

            return Locate(phases.Skip(1).ToArray(), newCommand.Items);
        }
        
    }
}
