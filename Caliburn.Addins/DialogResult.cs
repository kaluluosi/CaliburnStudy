using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins
{
     public struct DialogResult<TViewModel>
    {
        public TViewModel ViewModel;
        public bool? Result;
    }
}
