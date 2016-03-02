using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands {
    /// <summary>
    /// 定义菜单路径 路径格式例子"文件(_F).最近文件"
    /// </summary>
    public class MenuPathAttribute:Attribute {

        public MenuPathAttribute(string path) {
            Path = path;
        }


        public string Path { get; set; }

    }
}
