using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            //User u2 = null;
            using (BloggingContainer dc = new BloggingContainer())
            {
                dc.Database.Log = x => Console.WriteLine(x);
                
                //User u = dc.UserSet.FirstOrDefault(x => x.Id == 1);

                //Blog b = new Blog();
                //dc.BlogSet.Add(b);

                //BlogItem bi = new BlogItem() { User = u, Blog = b };
                //dc.BlogItemSet.Add(bi);
                //dc.SaveChanges();

                //dc.Database.
                //var c = dc.UserSet.FirstOrDefault().BlogItems.ToList();

            }
            
        }
    }
}
