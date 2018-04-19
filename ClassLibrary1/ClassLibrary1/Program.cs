using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Program
    {
        static void Main()
        {
            ICollection<int> source = new List<int>() { 1,2,3,4,5};
            CustomCollection<int> c = new CustomCollection<int>(source);

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

        }
    }
}
