using Caliburn.Micro;
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
    public interface IAppCommand:ICommand,IHotKey,IDisplay,ICheckable,IOwner,IObservableParent<IAppCommand> {
        /// <summary>
        /// 命令是否可见
        /// </summary>
        bool IsVisible { get; set; }
        /// <summary>
        /// 命令在CommandService里组装完毕后会调用这个方法
        /// </summary>
        void OnAttach();
    }


}
