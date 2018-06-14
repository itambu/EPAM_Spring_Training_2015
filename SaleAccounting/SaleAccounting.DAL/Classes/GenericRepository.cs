using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleAccounting.DAL.Classes
{
    public class GenericRepository<T> : Interfaces.IGenericRepository<T> where T: class
    {
        private DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Remove(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public void Update(T obj)
        {
            _context.Set<T>().Attach(obj);
            _context.Entry<T>(obj).State = EntityState.Modified;
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
