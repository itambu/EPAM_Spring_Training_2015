using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IModelRepository<T> 
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        IEnumerable<T> Items { get; }
        void SaveChanges();
    }
}
