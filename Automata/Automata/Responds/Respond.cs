using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Responds
{
    public class Respond
    {
        public Requests.Request Request;
        public PhoneNumber Source { get; set; }
        public RespondState State { get; set; }
    }
}
