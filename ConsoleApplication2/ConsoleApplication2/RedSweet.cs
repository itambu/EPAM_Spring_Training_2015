using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RedSweet : Sweet, IExecuteAction
    {
        public RedSweet(double sugar)
            : base(sugar)
        {
        }

        public void GoToMatrix()
        {
        }

        public void Action()
        {
            GoToMatrix();
        }
    }
}
