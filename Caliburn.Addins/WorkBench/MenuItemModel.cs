using Caliburn.Addins.Commands;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caliburn.Addins.WorkBench {
    /// <summary>
    /// 菜单项模型
    /// </summary>
    public class MenuItemModel {

        private string header;
        private string inputGestureText;

        /// <summary>
        /// 子菜单集合
        /// </summary>
        public ObservableCollection<MenuItemModel> Items { get; set; } = new ObservableCollection<MenuItemModel>();
        public IAppCommand Command { get; set; }

        public string Header
        {
            get
            {
                return Command == null ? header : Command.Name;
            }
            set
            {
                header = value;
            }
        }

        public string InputGestureText
        {
            get
            {
                return Command == null ? inputGestureText : Command.HotKeyText;
            }
            set
            {
                inputGestureText = value;
            }
        }


    }
}
