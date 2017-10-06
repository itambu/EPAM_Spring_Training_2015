using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MyCollection
    {
        private ICollection<int> collection 
            = new List<int>() { 1, 2, 3, 4 };

        IEnumerable<int> Revert()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection.ElementAt(i);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            IEnumerable<int> collection = a;


            //foreach(var item in iterator)
            //{
            //    item.GetType();
            //    //
            //}

            using (IEnumerator<int> iterator = 
                collection.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    var item = iterator.Current;
                    //
                }
            }
        }
    }
}
