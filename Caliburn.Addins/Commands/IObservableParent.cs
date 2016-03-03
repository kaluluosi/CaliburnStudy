using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands
{

    /// <summary>
    /// 父节点接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservableParent<T>
    {
        ObservableCollection<T> Items { get; }
    }
}
