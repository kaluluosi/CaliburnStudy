using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands
{
    /// <summary>
    /// 空命令，主要是用来作为父菜单项的
    /// </summary>
    public class EmptyCommand : AppCommandBase
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            
        }
    }
}
