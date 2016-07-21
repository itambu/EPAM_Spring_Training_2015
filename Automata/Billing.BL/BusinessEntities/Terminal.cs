using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities
{
    public class Terminal : ITerminal
    {
        public string TerminalNumber
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }

        public Terminal(Guid id, string number)
        {
            Id = id;
            TerminalNumber = number;
        }
    }
}
