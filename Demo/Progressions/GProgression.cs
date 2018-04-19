using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public class GProgression : Progression, IProgression
    {
        private double start;

        public double Start
        {
            get { return start; }
            private set { start = value; }
        }
        private double denominator;

        public double Denominator
        {
            get { return denominator; }
            private set { denominator = value; }
        }

        public GProgression(double start, double denominator)
        {
            Start = start;
            Denominator = denominator;
        }

        public override double this[int index]
        {
            get { return start*Math.Pow(denominator, index); }
        }


    }
}
