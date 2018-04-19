using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Subscriber
    {
        public void SubsciberAction(object sender, EventArgs args)
        {
            Console.WriteLine("Hi, bro!");
        }
    }
}
