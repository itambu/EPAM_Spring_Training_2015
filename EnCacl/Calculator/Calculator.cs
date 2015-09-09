using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private double[] items;
        
        public Calculator(int stackSize)
        {
            this.items = new double[stackSize];
        }
        
        public double this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.GetLength(0); }
        }

        public double Top
        {
            get
            {
                return items[Count -1];
            }
            set
            {
                items[Count - 1] = value;
            }
        }

        public void Push()
        {
            throw new NotImplementedException();
        }

        public void Pop()
        {
            throw new NotImplementedException();
        }

        public void Turn()
        {
            throw new NotImplementedException();
        }

        public void CycleTurn()
        {
            throw new NotImplementedException();
        }

        public void Plus()
        {
            throw new NotImplementedException();
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }

        public void Mult()
        {
            throw new NotImplementedException();
        }

        public void Div()
        {
            throw new NotImplementedException();
        }
    }
}
