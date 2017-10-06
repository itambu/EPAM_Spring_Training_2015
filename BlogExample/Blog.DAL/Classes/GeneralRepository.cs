using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Classes
{
    public class GeneralRepository<Entity, Interface> : 
        Interfaces.IGeneralRepository<Entity, Interface> where Entity : class, Interface
    {
        private Blog.Entities.BlogModelContainer _context;

        public GeneralRepository()
        {
            _context = new Entities.BlogModelContainer();
        }

        public void Add(Interface entity)
        {
            _context.Set<Entity>().Add(entity as Entity);
        }

        public void Delete(Interface entity)
        {
            _context.Set<Entity>().Remove(entity as Entity);
        }

        public IQueryable<Interface> GetSet()
        {
            return _context.Set<Entity>().Cast<Interface>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
