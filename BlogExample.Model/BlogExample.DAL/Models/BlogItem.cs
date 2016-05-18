using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.DAL.Models
{
    public class BlogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
