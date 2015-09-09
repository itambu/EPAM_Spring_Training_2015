using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    public class CallInfo
    {

        public PhoneNumber Source { get; set; }
        public PhoneNumber Target { get; set; }
        public DateTime Started { get; set; }
        public TimeSpan Duration { get; set; }

    }
}
