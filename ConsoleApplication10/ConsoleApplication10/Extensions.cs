using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public static class Extensions
    {
        public static IEnumerable<T> ToConsole<T>(this IEnumerable<T> source, Func<T, string> toStringFunc)
        {
            if (toStringFunc != null)
            {
                foreach (var p in source)
                {
                    Console.WriteLine(toStringFunc(p));
                    yield return p;
                }
            }
            else
            {
                throw new NullReferenceException("toStringFunc parameter should be not null");
            }
        }
    }
}
