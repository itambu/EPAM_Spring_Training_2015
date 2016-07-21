using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.ModelInterfaces;

namespace Billing.Model
{
    public partial class BillingModelContainer 
    {
        public BillingModelContainer(System.Data.Common.DbConnection connection) : base(connection, true)
        {
            this.Database.Log = message => Console.WriteLine(message);
        }
    }
}
