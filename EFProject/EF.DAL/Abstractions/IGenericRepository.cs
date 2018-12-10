using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.DAL.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        void Save();
    }
}
