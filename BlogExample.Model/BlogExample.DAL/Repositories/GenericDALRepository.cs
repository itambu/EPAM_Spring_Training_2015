using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.DAL.Repositories
{
    internal abstract class GenericDALRepository<DTO, Entity, Context> : IRepository<DTO, Entity>
        where DTO : class
        where Context : System.Data.Entity.DbContext
        where Entity : class
    {
        protected Context _context;
        public GenericDALRepository(IDataContextFactory<Context> factory)
        {
            _context = factory.ContextObject;
        }
        
        public void Add(DTO obj)
        {
            // 
            Entity entity = ToEntity(obj);

            var temp = _context.Set<Entity>().Attach(entity);
            if (temp != null)
            {
                _context.Entry<Entity>(temp).State = System.Data.Entity.EntityState.Detached;
            }
            else
            {
                _context.Set<Entity>().Add(entity);
            }
        }

        public void Remove(DTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTO> FirstOrDefault(System.Linq.Expressions.Expression<Func<DTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTO> GetMany(System.Linq.Expressions.Expression<Func<DTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context= null;
            }
        }

        ~GenericDALRepository()
        {
            if (_context != null)
            {
                Dispose();
            }
        }

        public abstract Entity ToEntity(DTO source);
        
    }
}
