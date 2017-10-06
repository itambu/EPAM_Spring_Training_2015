using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mock
{
    public class GereralRepository<Entity> : DAL.Interfaces.IGeneralRepository<Entity>
    {
        private ICollection<Entity> _collection;

        public GereralRepository(ICollection<Entity> source)
        {
            _collection = source;
        }


        public void Add(Entity entity)
        {
            _collection.Add(entity);
        }

        public void Remove(Entity entity)
        {
            _collection.Remove(entity);
        }


        public void SaveChanges()
        {
            
        }
    }
}
