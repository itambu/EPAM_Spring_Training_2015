using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.ModelInterfaces
{
    public interface IContractBillingPlanBinding : IEntity
    {
        System.DateTime BindingDate { get; }
        IContract Contract { get; }
        IBillingPlan BillingPlan { get; }
    }
}
