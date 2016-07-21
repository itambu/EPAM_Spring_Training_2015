using Billing.Model;
using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DAL
{
    public class CallInfoRepository : BillingRepository<ICallInfo, CallInfo>
    {
    }
}
