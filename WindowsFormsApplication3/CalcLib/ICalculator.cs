using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public interface ICalculator
    {
        double Sum(double a, double b);
        void Push(double arg);
        double Pop();
        void RotateCW();
        void RotateCCW();

        double this[int index]
        {
            get;
        }

        double HeadRegister { get; set; }

        int RegisterCount { get; }
    }
}
