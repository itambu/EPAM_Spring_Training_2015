using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Test
{
    class TestStation : Station
    {
        public TestStation(ICollection<ITerminal> terminalCollection, ICollection<IPort> portCollection): base(terminalCollection, portCollection)
        {
            
        }
        
        /// <summary>
        /// event handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="request"></param>
        public void OnOutgoingRequest(object sender, Requests.Request request)
        {
            if (request.GetType() == typeof(Requests.OutgoingCallRequest))
            {
                RegisterOutgoingRequest(request as Requests.OutgoingCallRequest);
            }
        }

        public override void RegisterEventHandlersForTerminal(ITerminal terminal)
        {
            terminal.OutgoingConnection += this.OnOutgoingRequest;
            terminal.IncomingRespond += OnIncomingCallRespond;
        }

        public override void RegisterEventHandlersForPort(IPort port)
        {
            port.StateChanged += (sender, state) => { Console.WriteLine("Station detected the port changed its State to {0}", state); };
        }


    }
}
