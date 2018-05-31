using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApplication12
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine( ConfigurationManager.AppSettings["filePath"]);
        }
    }
}
