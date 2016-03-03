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
    public class TestCommand : AppCommandBase
    {

        public TestCommand()
        {
            Name = "测试命令";
            HotKey = new KeyGesture(Key.E, ModifierKeys.Alt);
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

    [Command]
    [MenuPath("文件(_F).测试(_T)")]
    public class Test2Command : AppCommandBase
    {

        public Test2Command()
        {
            Name = "测试命令2";
            HotKey = new KeyGesture(Key.F, ModifierKeys.Alt);
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

    [Command]
    [MenuPath("文件(_F).测试3")]
    public class Test3Command : AppCommandBase
    {

        public Test3Command()
        {
            Name = "测试命令3";
            IsCheckable = true;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show("Hello");
            IsChecked =! IsChecked;
        }
    }

    [Command]
    [MenuPath("编辑.测试2")]
    public class Test4Command : AppCommandBase
    {

        public Test4Command()
        {
            Name = "测试命令4";
            foreach(int i in Enumerable.Range(0, 10))
            {
                Items.Add(new DynamicCommand() { Name = "临时菜单项" + i });
            }
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

    public class DynamicCommand : AppCommandBase
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show("这是动态生成的");
        }
    }
}
