using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public class Handler
    {
        public void OnMyAction(object source, string message)
        {
            Console.WriteLine(message);
        }
    }
}
