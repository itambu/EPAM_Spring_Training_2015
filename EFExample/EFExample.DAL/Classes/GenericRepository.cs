using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.DAL.Classes
{
    public class GenericRepository<Entity, DALEntity> : IDisposable where Entity: class
    {
        private DataModel.BlogDataModelContainer _context;

        public GenericRepository(DataModel.BlogDataModelContainer context)
        {
            _context = context;
        }

        public GenericRepository()
        {
            _context = new DataModel.BlogDataModelContainer();
        }

        protected void ValidateContext()
        {
            if (_context == null)
            {
                throw new NullReferenceException("context was not created");
            }
        }

        public void SaveChanges()
        {
            ValidateContext();
            _context.SaveChanges();
        }



        // ? public Entity GetEntityById( id)


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
                _context = null;
            }
        }

        ~GenericRepository()
        {
            Dispose();
        }
    }
}
