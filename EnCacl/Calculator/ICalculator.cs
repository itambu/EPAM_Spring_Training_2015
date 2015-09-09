using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        double this[int index] { get; }
        int Count { get; }
        double Top { get; set; }

        void Push();
        void Pop();
        void Turn();
        void CycleTurn();

        void Plus();
        void Subtract();
        void Mult();
        void Div();
    }
}
