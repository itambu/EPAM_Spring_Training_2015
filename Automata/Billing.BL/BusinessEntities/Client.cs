using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.BusinessEntities
{
    public class Client : IUser
    {
        public Guid Id { get; set; }

        public string FullName
        {
            get;
            set;
        }
    }

}
