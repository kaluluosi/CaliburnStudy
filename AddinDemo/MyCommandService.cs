using Caliburn.Addins.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinDemo
{
    [Export(typeof(ICommandService))]
    public class MyCommandService:CommandService<ShellViewModel>
    {
    }
}
