using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            var q = from x in list 
                    where x % 2 == 0 
                    select x;

            var q1 = list
                .Where(x => x % 2 == 0)
                .Select(x => x)
                .ToConsole(x => String.Format("{0}", x)).ToList(); 
            

        }
    }
}
