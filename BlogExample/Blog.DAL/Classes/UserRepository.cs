using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Classes
{
    public class UserRepository : Blog.DAL.Interfaces.IUserRepository
    {
        private Blog.Entities.BlogModelContainer _datacontext;

        public UserRepository()
        {
            _datacontext = new Blog.Entities.BlogModelContainer();
            _datacontext.Database.Log += x => Console.WriteLine(x);
        }

        public void Add(Entities.Interfaces.IUser user)
        {
            if (_datacontext != null)
            {
                _datacontext.Set(typeof(Blog.Entities.User)).Add(user);
            }
        }

        public void Remove(Entities.Interfaces.IUser user)
        {
            if (_datacontext != null)
            {
                _datacontext.Set(typeof(Blog.Entities.User)).Remove(user);
            }
        }

        public void SaveChanges()
        {
            if (_datacontext != null)
            {
                _datacontext.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (_datacontext != null)
            {
                _datacontext.Dispose();
                _datacontext = null;
            }
        }

        ~UserRepository()
        {
            Dispose();
        }

        public IQueryable<Blog.Entities.Interfaces.IUser> GetSet()
        {
            return _datacontext.Set<Blog.Entities.User>();
        }
    }
}
