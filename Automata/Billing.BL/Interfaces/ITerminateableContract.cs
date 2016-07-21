using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.BL.Interfaces
{
    public interface ITerminateableContract : Billing.ModelInterfaces.IContract
    {
        void Terminate(DateTime date);
    }
}
