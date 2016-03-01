using System.Collections.Generic;

namespace Caliburn.Addins.Commands {
    public interface ICommandService {
        IEnumerable<IAppCommand> Commands { get; set; }

    }
}