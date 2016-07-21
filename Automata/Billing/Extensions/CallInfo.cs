using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Model
{
    public partial class CallInfo : ICallInfo
    {

        ITerminal ICallInfo.Source
        {
            get { return this.Source; }
        }

        ITerminal ICallInfo.Target
        {
            get { return this.Target; }
        }
    }
}
