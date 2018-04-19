using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        private static int myvar = 2;
        private static object syncObj = new object();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(MyThread1);
            Thread thread2 = new Thread(MyThread2);

            thread1.Start(3);
            thread2.Start(4);
            
            Console.WriteLine("By!");
            //thread.Abort();
            thread1.Join();
            thread2.Join();
        }

        static void MyThread1(object obj)
        {
            Thread.Sleep(1000);
            try
            {
                Monitor.Enter(syncObj);
                myvar = 6;
                Console.WriteLine(myvar);
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(syncObj);
            }
        }

        static void MyThread2(object obj)
        {
            Thread.Sleep(1000);
            try
            {
                Monitor.Enter(syncObj);
                myvar = 4;
                Console.WriteLine(myvar);
                Monitor.Exit(syncObj);
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
