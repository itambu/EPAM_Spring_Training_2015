using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    public static class Extensions
    {
        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int count)
        {
            IEnumerator<T> iterator = source.GetEnumerator();
            int temp = 0;
            while (iterator.MoveNext() && temp < count)
            {
                yield return iterator.Current;
                temp++;
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        private int _age;
        public int Age 
        { 
            get { return _age; } 
            set { _age = value; } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> source = new List<Person>()
            {
                new Person(){Name="Bill", Age=5},
                new Person(){Name="John", Age=6},
                new Person(){Name="Cat", Age=6},
                new Person(){Name="Mary", Age=5}
            };

            var q1 = from x in source
                     where x.Age == 5
                     select x.Name;

            var q2 = source.Where(x => x.Age == 5)
                //.OrderBy(x => x.Name)
                .Select(x => x.Name).Top(10);

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
