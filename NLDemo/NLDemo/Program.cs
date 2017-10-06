using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLDemo
{
    public class Program
    {
        static void Main()
        {
            var unity = new BL.Mock.Unity(new DAL.Mock.GereralRepository<DAL.Interfaces.IUser>(new List<DAL.Interfaces.IUser>()));
            unity.Add(new BL.Mock.User() { FirstName = "Вася", LastName = "Петров" });
        }
    }
}
