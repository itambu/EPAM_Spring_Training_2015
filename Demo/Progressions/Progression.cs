using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public abstract class Progression : IGetSum, IGetItem
    {
        public abstract double this[int index]
        {
            get;
        }

        public double Sum(int start, int count)
        {
            double s = 0;
            for (int i = start; i < start + count; i++)
            {
                s += ((IGetItem)this)[i];
            }
            return s;
        }
    }
}
