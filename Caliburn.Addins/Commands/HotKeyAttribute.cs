using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caliburn.Addins.Commands {
    /// <summary>
    /// 默认热键特性
    /// </summary>
    public class HotKeyAttribute:Attribute {

        public HotKeyAttribute(Type Owner,Key key,ModifierKeys modifiers) {
            OwnerView = Owner;
            Key = key;
            Modifiers = modifiers;
        }

        public Key Key { get; private set; }
        public ModifierKeys Modifiers { get;private set; }

        /// <summary>
        /// 这个热键要注册到的View
        /// </summary>
        public Type OwnerView { get;private set; }
    }
}
