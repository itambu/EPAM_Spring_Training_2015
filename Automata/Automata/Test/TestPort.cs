using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Test
{
    class TestPort : Port
    {
        public void OnOutgoingCall(object sender, Requests.Request request)
        {
            if (request.GetType() == typeof(Requests.OutgoingCallRequest) && this.State==PortState.Free )
            {
                this.State = PortState.Busy;
            }
        }

        public override void RegisterEventHandlersForTerminal(ITerminal terminal)
        {
            terminal.OutgoingConnection += this.OnOutgoingCall;
            terminal.Plugging += (port, args) => { this.State = PortState.Free; };
            terminal.UnPlugging += (port, args) => { this.State = PortState.UnPlagged; };
        }

        public TestPort()
        {
            this.StateChanged += (sender, state) => { Console.WriteLine("Port detected the State is changed to {0}", state); };
        }

    }
}
