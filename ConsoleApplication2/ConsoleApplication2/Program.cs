using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private ICollection<T> collection;

        public MyCollection(ICollection<T> source)
        {
            collection = source;
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> temp = new List<T>();
            foreach (var item in collection)
            {
                if (!temp.Contains(item))
                {
                    temp.Add(item);
                    yield return item; 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerable<T> UserIterator()
        {
            List<T> temp = new List<T>();
            foreach (var item in collection)
            {
                if (!temp.Contains(item))
                {
                    temp.Add(item);
                    yield return item;
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {


            MyCollection<int> ilist = new MyCollection<int>(new List<int>() { 7, 1, 2, 3, 2, 4, 1, 6, 6, 3, 7 });

            foreach (var item in ilist.UserIterator())
            {
                Console.WriteLine(item);
            }
        }
    }
}
