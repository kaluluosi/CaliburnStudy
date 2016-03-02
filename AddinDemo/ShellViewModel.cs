using Caliburn.Addins.Commands;
using Caliburn.Addins.WorkBench;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinDemo
{
    [Export(typeof(IShell))]
    public class ShellViewModel:Screen,IShell,IPartImportsSatisfiedNotification
    {

        [Import]
        ICommandService CommandService { get; set; }

        public IEnumerable<MenuItemModel> Menus
        {
            get
            {
                return CommandService.Menus;
            }
        }

        public IEnumerable<IAppCommand> Commands
        {
            get
            {
                return CommandService.Commands;
            }
        }

        public ShellViewModel()
        {
            
        }

        public void OnImportsSatisfied()
        {
            
        }
    }
}
