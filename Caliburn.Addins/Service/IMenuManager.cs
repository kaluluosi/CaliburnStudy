using System.Collections.ObjectModel;
using Caliburn.Addins.Commands;

namespace Caliburn.Addins.Service
{
    public interface IMenuManager
    {
        ObservableCollection<IAppCommand> Menus { get; }
    }
}