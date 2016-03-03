using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins.Commands
{
    public interface IOwner
    {
        Type Owner { get; set; }
    }
}
