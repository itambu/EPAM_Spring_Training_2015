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
            List<string> list = new List<string>()
            {
                "крокодилы",
                "бегемоты",
                "жирафы"
            };

            var query = from x in list
                        where x.StartsWith("кроко")
                        select new
                        {
                            Name = String.Format(
                                "вкусные и полезные {0}", x),
                            Count = 1.0
                        };

            var query1 = list.Where(x => x.StartsWith("кроко"))
                .Select(x => String.Format(
                        "вкусные и полезные {0}", x));

            foreach (var item in query)
            {
                Console.WriteLine( item.Count);
            }




        }
    }
}
