using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.ModelInterfaces
{
    public interface ITerminal : IEntity
    {
        string TerminalNumber { get; }
    }
}
