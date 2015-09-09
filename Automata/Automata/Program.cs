using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automata.Test;

namespace Automata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPort> ports = new List<IPort>() { new TestPort(), new TestPort() };
            List<ITerminal> terminals = new List<ITerminal>(){
            };

            TestStation s = new TestStation(terminals, ports);

            s.Add(new TestTerminal(new PhoneNumber("000-00-0")));
            s.Add(new TestTerminal(new PhoneNumber("111-11-1")));

            foreach (var t in terminals)
            {
                t.Plug();
            }

            //terminals[0].Call( new PhoneNumber("111-11-1"));
            //terminals[0].Answer();
            terminals[1].Drop();
        }
    }
}
