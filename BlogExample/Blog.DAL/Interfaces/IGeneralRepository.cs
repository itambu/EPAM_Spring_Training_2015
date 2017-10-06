using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Interfaces
{
    public interface IGeneralRepository<Entity, Interface> 
        where Entity : Interface 
    {
        void Add(Interface entity);
        void Delete(Interface entity);
        IQueryable<Interface> GetSet();
        void SaveChanges();
    }
}
