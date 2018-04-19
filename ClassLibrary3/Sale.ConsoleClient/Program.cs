using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sale.Entity;

namespace Sale.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SaleModel context = new SaleModel())
            {
                context.Database.Log = s => Console.WriteLine(s);
                Item item = new Item() { Name = "Грабли чудесные" };
                context.Items.Add(item);
                context.SaveChanges();

                var query = context.Items.Where(x => x.Name == "Грабли");

                foreach (var i in query)
                {
                }
            }

        }
    }
}
