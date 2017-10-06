using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class BigBlueSweet : BlueSweet, IExecuteAction
    {
        public new void Action()
        {
            GoToReal();
            GoToReal();
        }

        public BigBlueSweet(double sugar)
            : base(sugar)
        {
        }
    }
}
