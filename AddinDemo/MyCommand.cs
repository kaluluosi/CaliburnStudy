using Caliburn.Addins.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AddinDemo
{
    [Export(typeof(IAppCommand))]
    public class MyCommand : AppCommandBase
    {
        public MyCommand()
        {
            Name = "我的";
            ToolTip = "吊的不行";
            HotKey = new System.Windows.Input.KeyGesture(System.Windows.Input.Key.E, System.Windows.Input.ModifierKeys.Alt);
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
