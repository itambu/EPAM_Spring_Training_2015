using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static int sum = 0;
        static object syncObj = new object();
        static void Tread1(object obj)
        {
            for (int i = 0; i < 1000000; i++)
            {
               Interlocked.Add(ref sum, i * i);
            }
            Console.WriteLine("t1 finished");
        }

        static void Tread2(object obj)
        {
            for (int i = 0; i < 1000000; i++)
            {
                bool entered = false;
                try
                {
                    entered = Monitor.TryEnter(syncObj, 1);
                    if (entered)
                    {
                        sum += i * i;
                    }
                }
                finally
                {
                    if (entered)
                    {
                        Monitor.Exit(syncObj);
                    }
                }
            }
            Console.WriteLine("t2 finished");
        }       

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Tread1);
            Thread t2 = new Thread(Tread2);

            int p,q;
            ThreadPool.GetMaxThreads(out p, out q);

            Console.WriteLine("{0} {1}", p, q);
            ThreadPool.QueueUserWorkItem(Tread1);
            ThreadPool.QueueUserWorkItem(Tread2);
            //t1.Start();
            //t2.Start();


            //t1.Join();
            //t2.Join();
            Console.WriteLine("Main finished {0}", sum);
        }
    }
}
