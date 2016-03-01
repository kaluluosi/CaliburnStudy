using Caliburn.Addins.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddinDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();

            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(ApplicationCommands.Open, excuted));
        }

        private void excuted(object sender, ExecutedRoutedEventArgs e) {
            MessageBox.Show("hello");
        }
    }
}
