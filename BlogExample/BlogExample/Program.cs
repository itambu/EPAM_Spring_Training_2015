using Blog.BL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Unity unity = new Unity();
            unity.GetUsers(null);

        }
    }
}
