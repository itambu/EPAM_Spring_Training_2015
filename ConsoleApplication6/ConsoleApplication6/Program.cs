using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate mydelegate = MyCond1;
            IndexOf(null, MyCond1);

            List<int> list = new List<int>() { 1, 2, 3 };
            //list.Find
        }

        public delegate bool Predicate(int p);

        static int IndexOf(int[] array, Predicate condition)
        {
            int result = -1;
            int i = 0;
            while (i < array.GetLength(0) && condition(array[i]))
            {
                i++;
            }

            if (i < array.GetLength(0))
            {
                result = i;
            }
            return result;
        }

        static bool MyCond1(int p)
        {
            return p == 10;
        }

    }
}
