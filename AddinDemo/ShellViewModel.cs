using AddinDemo.TestAddin;
using Caliburn.Addins.Commands;
using Caliburn.Addins.Service;
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
    public class ShellViewModel:Screen,IShell
    {

        [Import]
        public ICommandService CommandService { get; set; }

        [Import]
        public IMenuManager MenuBar { get; set; }

        public TestCommand TestCmd { get; set; } = new TestCommand();

        public ObservableCollection<IAppCommand> Commands
        {
            get
            {
                return CommandService.Commands;
            }
        }


        public ShellViewModel()
        {
            
        }

    }
}
