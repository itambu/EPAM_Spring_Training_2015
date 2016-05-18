using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            var bufferBlock = new BufferBlock<int>();

            // Write to and read from the message block concurrently.
            var post01 = Task.Run(() =>
            {
                Task.Delay(1000);
                bufferBlock.Post(0);
                Console.WriteLine("Post 0");
                Task.Delay(1000);
                bufferBlock.Post(1);
                Console.WriteLine("Post 1");
            });
            
            var receive = Task.Run(() =>
            {
                Task.Delay(500);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Wait for data");
                    Console.WriteLine(bufferBlock.Receive());
                }
            });

            var post2 = Task.Run(() =>
            {
                bufferBlock.Post(2);
                Console.WriteLine("Post 2");
            });
            Task.WaitAll(post01, receive, post2);

        }
    }
}
