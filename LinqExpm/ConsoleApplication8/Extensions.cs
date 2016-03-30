using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public static class Extensions
    {
        public static IEnumerable<T> ToConsole<T>(this IEnumerable<T> source, Func<T, string> projector)
        {
            foreach (var p in source)
            {
                Console.WriteLine(projector(p));
                yield return p;
            }
        }
    }
}
