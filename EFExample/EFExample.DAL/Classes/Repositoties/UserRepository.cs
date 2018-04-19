using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.DAL.Classes.Repositoties
{
    public class UserRepository : GenericRepository<EFExample.DataModel.User, DAL.Classes.Models.User>
    {
        private System.Data.Entity.DbSet<EFExample.DataModel.User> dbSet;

        public UserRepository(DataModel.BlogDataModelContainer context)
        {
            dbSet = context.Users;
        }
       
        public void Add(DAL.Classes.Models.User user)
        {
            ValidateContext();

            if (user == null)
            {
                throw new ArgumentNullException("entity cannot be null");
            }

            dbSet.Add(new EFExample.DataModel.User() { Alias = user.Alias });
        }

        public IEnumerable<DAL.Classes.Models.User> Get(Expression<Func<DAL.Classes.Models.User, bool>> expression)
        {

        }
    }
}
