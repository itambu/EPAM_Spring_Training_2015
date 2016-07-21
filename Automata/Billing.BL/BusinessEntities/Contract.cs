using Billing.BL.Interfaces;
using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities
{
    public class Contract : ITerminateableContract
    {
        public DateTime ContractStartDate
        {
            get;
            set;
        }

        public DateTime? ContractCloseDate
        {
            get;
            set;
        }

        public IUser Client
        {
            get;
            set;
        }

        public ITerminal Terminal
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }

        public void Terminate(DateTime date)
        {
            ContractCloseDate = date;
        }
    }
}
