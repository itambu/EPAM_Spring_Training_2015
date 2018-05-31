using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {

            using (CancellationTokenSource tokenSource = new CancellationTokenSource())
            {
                Task task = Task.Factory.StartNew(ThreadFunc, tokenSource, tokenSource.Token);
                Thread.Sleep(1000);
                tokenSource.Cancel();
            }
        }


        static void ThreadFunc(object param)
        {
            try
            {
                int count = 100;
                int index = 0;
                while (index++ < count)
                {
                    Thread.Sleep(100);
                    if (param != null && (param as CancellationTokenSource).IsCancellationRequested)
                    {
                    }
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("");
            }
        }
    }


}
