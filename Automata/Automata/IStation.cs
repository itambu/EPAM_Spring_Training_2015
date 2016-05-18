using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    public interface IStation : IShouldClearEventHandlers
    {
        void RegisterEventHandlersForTerminal(ITerminal terminal);
        void RegisterEventHandlersForPort(IPort port);

        event EventHandler<CallInfo> CallInfoPrepared;
    }
}
