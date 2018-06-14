using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleAccounting.DAL.Interfaces
{
    public interface IGenericRepository<T> where T: class
    {
        void Add(T obj);
        void Remove(T obj);
        void Update(T obj);
        IQueryable<T> Get();
        void Save();
    }
}
