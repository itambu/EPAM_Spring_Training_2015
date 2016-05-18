using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.DAL
{
    class BlogItemRepository
    {
        void Update(BlogExample.DAL.Models.BlogItem blogItem)
        {
            using (var dc = new BlogExample.Model.ModelContainer())
            {
                // automapper
                //var a = new BlogExample.Model.Author() { FirstName = author.FirstName, LastName = author.LastName };
                var b = dc.BlogItemSet.FirstOrDefault(x => x.Id == blogItem.Id);
                b.Title = blogItem.Title;
                b.Context = blogItem.Context;
                b.AuthorToBlog.Clear();
                
                
                //b.AuthorToBlog.Add(

                dc.SaveChanges();
            }
        }
    }
}
