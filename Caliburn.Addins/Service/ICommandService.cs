using Caliburn.Addins.WorkBench;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Caliburn.Addins.Commands {
    public interface ICommandService {
        ObservableCollection<IAppCommand> Commands { get; set; }
        void Configure();
    }
}