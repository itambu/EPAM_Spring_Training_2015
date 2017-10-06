using Blog.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Blog.BL.Classes
{
    public class Unity
    {
        void Add(IUser user)
        {
            using (Blog.DAL.Interfaces.IUserRepository userRepo = new Blog.DAL.Classes.UserRepository())
            {
                Blog.Entities.Interfaces.IUser userDAL =
                    new Blog.Entities.User()
                    {
                        Id = user.Id,
                        Alias = user.Alias,
                        Contact = user.Contact
                    };

                userRepo.Add(userDAL);
                userRepo.SaveChanges();
            }
        }


        public IEnumerable<IUser> GetUsers(Expression<Func<IUser, bool>> predicate)
        {
            using (Blog.DAL.Interfaces.IUserRepository userRepo = new Blog.DAL.Classes.UserRepository())
            {
                return userRepo.GetSet()
                    .Where(x => predicate(x))
                    .Take(3)
                    .Select(x=> new User(){Id = x.Id, Alias = x.Alias, Contact = x.Contact}).ToArray();
            }
        }
    }
}
