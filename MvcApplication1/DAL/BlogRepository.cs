using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogRepository
    {
        private static ICollection<Blog> list = new List<Blog>()
        {
            new Blog(){ Id = 1, Description = "dddddddddddddddddd", PublishDate = DateTime.Now},
             new Blog(){ Id = 2, Description = "ssssssssss", PublishDate = DateTime.Now},
              new Blog(){ Id = 3, Description = "pppppppppppp", PublishDate = DateTime.Now}
        };

        public IEnumerable<Blog> GetAll()
        {
            return list;
        }
    }
}
