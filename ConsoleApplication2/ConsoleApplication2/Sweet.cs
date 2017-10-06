using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class Sweet
    {
        public double Sugar
        {
            get;
            private set;
        }

        public double Calority
        {
            get
            {
                return Sugar*1.02;
            }
        }

        public Sweet(double sugar)
        {
            Sugar = sugar;
        }
    }
}
