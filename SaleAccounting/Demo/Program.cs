using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleAccounting.Entities;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EntityModelContainer dbcontext = new EntityModelContainer())
            {
                dbcontext.Database.Log = x=>Console.Write(x);
                Manager m = new Manager() { Name = "John" };
                dbcontext.Managers.Add(m);
                dbcontext.SaveChanges();

                Manager m1 = dbcontext.Managers.FirstOrDefault(x => x.Id == 1);

               
            }

        }
    }
}
