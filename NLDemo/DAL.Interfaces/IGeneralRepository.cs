using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGeneralRepository<in Entity>
    {
        void Add(Entity entity);
        void Remove(Entity entity);
        void SaveChanges();
    }
}
