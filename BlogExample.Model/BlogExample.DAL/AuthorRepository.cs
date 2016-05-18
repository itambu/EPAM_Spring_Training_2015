using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogExample.DAL
{
    class AuthorRepository
    {
        void Add(Models.Author author)
        {
            using (var dc = new BlogExample.Model.ModelContainer())
            {
                // automapper
                var a = new BlogExample.Model.Author() { FirstName = author.FirstName, LastName = author.LastName };
                dc.AuthorSet.Add(a);
                dc.SaveChanges();
            }
        }
    }
}
