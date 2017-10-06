using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Interfaces
{
    public interface IUserRepository : IDisposable      
    {
        void Add(Blog.Entities.Interfaces.IUser user);
        void Remove(Blog.Entities.Interfaces.IUser user);
        void SaveChanges();
        IQueryable<Blog.Entities.Interfaces.IUser> GetSet();
    }
}
