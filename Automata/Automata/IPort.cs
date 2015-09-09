using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    public interface IPort : IShouldClearEventHandlers
    {               
        PortState State { get; set; }

        event EventHandler<PortState > StateChanging;
        event EventHandler<PortState> StateChanged;

        void RegisterEventHandlersForTerminal(ITerminal terminal);
    }
}
