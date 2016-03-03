using Caliburn.Addins.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinDemo
{
    [Export(typeof(IMenuManager))]
    public class MenuBarViewModel : MenuManager
    {
    }
}
