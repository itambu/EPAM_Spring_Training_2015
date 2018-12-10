using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entites.Factory
{
    public class BlogContextFactory : Abstractions.IDbContextFactory
    {
        public System.Data.Entity.DbContext CreateInstance()
        {
            return new BlogDbContext();
        }
    }
}
