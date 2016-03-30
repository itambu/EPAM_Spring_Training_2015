using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate objects
            BindingEventList<int> list = new BindingEventList<int>();
            ListView listView = new ListView();

            //--------------------------------------------------------
            // subscribe to event

            list.AddEvent += listView.OnNewItem;

            //--------------------------------------------------------
            // generate event

            list.Add(10);
            list.Add(5);

            list.AddEvent -= listView.OnNewItem;
            list.Add(7);

            //-------------------------------------------------------
            int myvar = 20;
            var dg = new Predicate<int>(
                delegate(int item)
                {
                    return item == 10 + myvar;
                }
                );

            int result = list.Find(dg);
            TestMethod(dg);
        }

        static void TestMethod(Predicate<int> d)
        {
            d(10);
        }

        //static bool MyCriteria(int item)
        //{
        //    return item == 10;
        //}
    }
}
