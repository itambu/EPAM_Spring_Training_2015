using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calculator : ICalculator
    {
        private double[] _registers = null;

        public Calculator(int RegisterCount)
        {
            _registers = new double[RegisterCount];
            this.RegisterCount = RegisterCount;
        }

        

        public double Sum(double a, double b)
        {
            return a + b;
        }


        public void Push(double arg)
        {
            for (int i = _registers.Length - 2; i >= 0; i--)
            {
                _registers[i + 1] = _registers[i];
            }

            _registers[0] = arg;
        }

        public double Pop()
        {
            throw new NotImplementedException();
        }

        public void RotateCW()
        {
            throw new NotImplementedException();
        }

        public void RotateCCW()
        {
            throw new NotImplementedException();
        }


        public double this[int index]
        {
            get { return _registers[index]; }
        }


        public int RegisterCount
        {
            get;
            private set;
        }


        public double HeadRegister
        {
            get
            {
                return _registers[0];
            }
            set
            {
                _registers[0] = value;
            }
        }
    }
}
