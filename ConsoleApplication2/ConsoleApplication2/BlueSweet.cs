using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class BlueSweet : Sweet, IExecuteAction
    {
        public BlueSweet(double sugar)
            : base(sugar)
        {
        }

        public new double Calority
        {
            get { return Sugar * 1.5; }
        }

        public void GoToReal()
        {
        }

        public void Action()
        {
            GoToReal();
        }
    }
}
