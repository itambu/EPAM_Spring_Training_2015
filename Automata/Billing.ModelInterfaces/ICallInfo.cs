using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.ModelInterfaces
{
    public interface ICallInfo : IEntity
    {
        DateTime Started { get; }
        TimeSpan Duration { get; }

        ITerminal Source { get; }
        ITerminal Target { get; }
        Decimal Cost { get; }
    }
}
