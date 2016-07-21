using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.ModelInterfaces;

namespace Billing.Model
{
    public partial class ContractBillingPlanBinding : IContractBillingPlanBinding
    {

        IContract IContractBillingPlanBinding.Contract
        {
            get { return Contract; }
        }

        IBillingPlan IContractBillingPlanBinding.BillingPlan
        {
            get { return BillingPlan; }
        }
    }
}
