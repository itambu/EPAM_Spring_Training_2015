using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Test
{
    class TestTerminal : Terminal
    {
        public TestTerminal(PhoneNumber number): base(number)
        {
            this.IncomingRequest += this.OnIncomingRequest;
            this.Online += (sender, args) => { Console.WriteLine("Terminal {0} turned to online mode", Number); };
            this.Offline += (sender, args) => { Console.WriteLine("Terminal {0} turned to offline mode", Number); };
        }

        protected override void OnIncomingRequest(object sender, Requests.IncomingCallRequest request)
        {
            //base.OnIncomingRequest(sender, request);
            Console.WriteLine("{0} received request for incoming connection from {1}", this.Number, request.Source);
        }
    }
}
