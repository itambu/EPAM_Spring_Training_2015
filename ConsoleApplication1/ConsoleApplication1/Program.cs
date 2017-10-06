using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(firstName: "John", lastName:"Smith");

            user.FirstName = "dsdeds";

            string fullName = user.FirstName + " " + user.GetLastName;

            user.GetUserAge(DateTime.Now).TotalDays;
        }
    }
}
