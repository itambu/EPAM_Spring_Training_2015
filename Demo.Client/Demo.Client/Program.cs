//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.Core.TestClass t = new Core.TestClass();
            Demo.Core.TestClass g = t;

            System.Console.WriteLine( 
                Demo.Core.TestClass.ReferenceEquals(t, g)
                );
        }
    }

    class Int32
    {
    }
}
