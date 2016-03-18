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
            Sender s = new Sender();
            Receiver r = new Receiver();
            Receiver r1 = new Receiver();
            Receiver r2 = new Receiver();

            EventHandler<string> h = null;

            //--------------------------
            s.MyEvent += r.Reaction + h;
            s.MyEvent += r1.Reaction;
            s.MyEvent -= r2.Reaction;


            //s.MyEvent = null;

            //--------------------------

            s.EventGenerator();
        }
    }
}
