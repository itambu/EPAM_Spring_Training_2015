using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CustomCollection(new List<int>() { 1, 2, 4, 5, 6 });

            IEnumerator<int> iterator = c.Revers().GetEnumerator();
            try
            {
                while (iterator.MoveNext())
                {
                    int item = iterator.Current;
                }
            }
            finally
            {
                if (iterator != null)
                {
                    iterator.Dispose();
                }
            }


            foreach (var item in c.Revers())
            {
                Console.WriteLine(item);
            }
            //-------------------------------------------------

            ArrayList list = new ArrayList();

            list.Add("dddd");
            list.Add(c);

            list.Add(1);
            double r = 1.5;
            list.Add(r);

            int t1 = (int)list[2];
            double t2 = (double)list[3];

        }
    }
}
