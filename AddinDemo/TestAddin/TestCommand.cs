using Caliburn.Addins.Commands;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AddinDemo.TestAddin
{
    [Command]
    [MenuPath("文件(_F).测试(_T)")]
    [HotKey(null, Key.E, ModifierKeys.Alt)]
    public class TestCommand : AppCommandBase
    {

        public TestCommand()
        {
            Name = "测试命令";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show("Hello");
        }
    }
}
