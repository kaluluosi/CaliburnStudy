using Caliburn.Addins.WorkBench;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Caliburn.Addins.Commands {
    public interface ICommandService {
        IEnumerable<IAppCommand> Commands { get; set; }

        ObservableCollection<MenuItemModel> Menus { get; set; }

    }
}