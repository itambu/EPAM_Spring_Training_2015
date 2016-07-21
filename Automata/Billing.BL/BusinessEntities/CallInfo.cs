using Billing.BL.Interfaces;
using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities
{
    public class CallInfo : ICostChangeableCallInfo
    {
        public DateTime Started
        {
            get;
            set;
        }

        public TimeSpan Duration
        {
            get;
            set;
        }

        public ITerminal Source
        {
            get;
            set;
        }

        public ITerminal Target
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }


        public decimal Cost
        {
            get;
            set;
        }
    }
}
