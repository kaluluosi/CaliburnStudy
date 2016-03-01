using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caliburn.Addins.Commands {

    /// <summary>
    /// 所有命令的基类
    /// </summary>
    public interface IAppCommand:ICommand {
        /// <summary>
        /// 命令名
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 命令显示的名字
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// 热键描述
        /// </summary>
        string HotKeyText { get; set; }
    }
}
