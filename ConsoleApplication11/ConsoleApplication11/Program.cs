using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {


        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 2, 3, 4
            };

            int r = list.Find(x => { return x > 2; });

            list.ForEach(x => Console.WriteLine(x));

            string p1, p2, p3;
            string p4 = String.Concat( p1 , p2 , p3);

            string[] array = new string[] { "", "", "" };

            String.Concat(array);

            string s = null;
            foreach (var item in array)
            {
                s += item;
            }

            String.Format("{0} - {1}", "a", "b");

            //---------------------------------------------
            
            EventSource es = new EventSource();
            Handler h = new Handler();

            //-------------------------------------

            int m = 10;

            EventHandler<string> p = delegate(object sender, string message)
                {
                    Console.WriteLine(m.ToString());
                };

            EventHandler<string> p1 = (sender, message) =>
                    { Console.WriteLine(message); };

            es.MyEvent += p;
                

            es.MyEvent += h.OnMyAction;

            //es.MyEvent = null;

            //EventHandler<string> p1 = h.OnMyAction;
            //EventHandler<string> p2 = h.OnMyAction;

            //if (Object.ReferenceEquals( p1 , p2))
            //{

            //}

            //if (p1 == p2)
            //{

            //}

            //-------------------------------------

            es.MyAction();

            //-------------------------------------

            es.MyEvent -= new EventHandler<string>( h.OnMyAction) + h.OnMyAction;
            //es.MyEvent -= h.OnMyAction;

            es.MyAction();
            
        }


    }
}
