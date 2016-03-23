using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "John", "Pet", "Helen" };

            string John = list.Find(new Predicate<string>(FindByCompleteMatch) +
                new Predicate<string>(FindStartWith));

            int mc = 10;
            Predicate<string> c = delegate(string source) 
            { 
                return source == "John" + mc; 
            };

            string pet = list.Find(c);
        }

        static bool FindByCompleteMatch(string source)
        {
            return source == "John";
        }

        static bool FindStartWith(string source)
        {
            return source.StartsWith("P");
        }
    }
}
