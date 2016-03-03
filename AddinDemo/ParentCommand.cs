using Caliburn.Addins.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinDemo
{
    public class ParentCommand : AppCommandBase
    {
        public ParentCommand()
        {
            Name = "父亲";
            ToolTip = "呵呵";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            
        }
    }
}
