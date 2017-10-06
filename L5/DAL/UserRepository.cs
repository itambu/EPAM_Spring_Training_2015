using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DAL
{
    public class UserRepository : IModelRepository<DAL.Models.User>
    {
        private Model.BloggingContainer context = new Model.BloggingContainer();

        Model.User ToEntity(DAL.Models.User source)
        {
            return new Model.User() { Id = source.Id, UserName = source.UserName };
        }

        DAL.Models.User ToObject(Model.User source)
        {
            return new DAL.Models.User() { Id = source.Id, UserName = source.UserName };
        }

        public void Add(DAL.Models.User item)
        {
            var e = this.ToEntity(item);
            context.UserSet.Add(e);
        }

        public void Remove(Models.User item)
        {
            var user = this.context.UserSet.FirstOrDefault(x=>x.Id==item.Id);
            if (user != null)
            {
                context.UserSet.Remove(user);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Update(Models.User item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.User> Items
        {
            get 
            {
                return this.context.UserSet.Select(x => this.ToObject(x));
                //foreach (var u in this.context.UserSet)
                //{
                //    yield return this.ToObject(u);
                //}
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
