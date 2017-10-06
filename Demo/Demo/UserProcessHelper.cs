using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class UserProcessHelper
    {
        public static void Process(this User[] users)
        {
            foreach (User u in users)
            {
                Console.WriteLine(u.FirstName);
            }
        }
    }
}
