using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects

            EventGenerator eg = new EventGenerator();
            Subscriber sc = new Subscriber();

            // subscribe 

            eg.Click += sc.SubsciberAction;
            eg.Click += sc.SubsciberAction;

            // fire event

            eg.MyAction();

            // unsubscribe
            eg.Click -= sc.SubsciberAction;


        }
    }
}
