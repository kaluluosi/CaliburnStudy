using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands {
    public class ContextMenuPathAttribute:MenuPathAttribute {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner">这个上下文菜单的拥有者ViewModel，这个值是用来检索上下文菜单的</param>
        /// <param name="path"></param>
        public ContextMenuPathAttribute(Type owner,string path):base(path) {

        }

        public Type Owner { get; set; }
    }
}
