using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities
{
    public class ContractBillingPlanBinding : IContractBillingPlanBinding
    {
        public DateTime BindingDate
        {
            get;
            set;
        }

        public IContract Contract
        {
            get;
            set;
        }

        public IBillingPlan BillingPlan
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }
    }
}
