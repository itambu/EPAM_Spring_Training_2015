using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    class Program
    {
        static void Main()
        {
            IProgression p = new AProgression(1, 1);
            Console.WriteLine(p.Sum(0, 10));
        }
    }
}
