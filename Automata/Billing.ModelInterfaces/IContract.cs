using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.ModelInterfaces
{
    public interface IContract : IEntity
    {
        DateTime ContractStartDate { get; }
        Nullable<DateTime> ContractCloseDate { get; }
        IUser Client { get; }
        ITerminal Terminal { get; }
    }
}
