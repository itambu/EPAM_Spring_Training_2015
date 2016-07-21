using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.Interfaces
{
    public interface ICostChangeableCallInfo : ICallInfo 
    {
        new Decimal  Cost { get; set; }
    }
}
