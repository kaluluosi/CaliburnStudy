using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands {
    /// <summary>
    /// 封装Export(typeof(IAppCommand))，更简单调用
    /// </summary>
    public class CommandAttribute : ExportAttribute { 
        public CommandAttribute():base(typeof(IAppCommand)){

        }
    }
}
