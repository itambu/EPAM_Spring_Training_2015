using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Requests
{
    public class OutgoingCallRequest: Request
    {
        public PhoneNumber Target { get; set; }
    }
}
