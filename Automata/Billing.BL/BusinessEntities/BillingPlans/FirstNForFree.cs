using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities.BillingPlans
{
    [Serializable]
    public class FirstNForFree : IBillingPlan
    {
        public FirstNForFree(Guid id, string name, decimal costPerMinute, int freeMinute)
        {
            Id = id;
            _costPerMinute = costPerMinute;
            _freeMinutes = freeMinute;
            Name = name;
        }

        private int _freeMinutes;
        private decimal _costPerMinute = 0.01m;

        public decimal CalculateCost(ICallInfo info, IEnumerable<ICallInfo> previousItems)
        {
            TimeSpan sum = new TimeSpan();
            previousItems.Aggregate(sum, (seed, x)=> seed + x.Duration);

            if (sum.TotalMinutes + info.Duration.TotalMinutes <= _freeMinutes)
            {
                return 0;
            }
            else
            {
                return (decimal)(sum.TotalMinutes + info.Duration.TotalMinutes - _freeMinutes) * _costPerMinute;
            }
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
