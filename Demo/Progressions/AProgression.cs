using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public class AProgression : Progression, IProgression
    {
        public override double this[int index]
        {
            get 
            { 
                return Start + Difference*index; 
            }
        }

        private double start;

        public double Start
        {
            get { return start; }
            private set { start = value; }
        }

        private double difference;

        public double Difference
        {
            get { return difference; }
            private set { difference = value; }
        }

        public AProgression(double start, double difference)
        {
            Start = start;
            Difference = difference;
        }

        public new double Sum(int start, int count)
        {
            return (this[start] + this[start + count - 1]) * count / 2;
        }

    }
}
