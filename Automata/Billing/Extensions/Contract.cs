using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.ModelInterfaces;

namespace Billing.Model
{
    public partial class Contract : IContract
    {
        IUser IContract.Client
        {
            get { return Client; }
        }

        ITerminal IContract.Terminal
        {
            get { return Terminal; }
        }
    }
}
