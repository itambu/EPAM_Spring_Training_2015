using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BL.DataCollector dc = new DataCollector();
                //dc.ProcessFile();
                DAL.Models.User user = new DAL.Models.User() { UserName = "John" };
                dc.AddUser(user);
            }
            catch (ArgumentException e)
            {
            }
            
            
        }
    }
}
