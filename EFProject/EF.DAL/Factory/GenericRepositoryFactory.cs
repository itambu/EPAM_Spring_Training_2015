using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF.DAL.Factory
{
    public class GenericRepositoryFactory : Abstractions.IRepositoryFactory
    {
        public Abstractions.IGenericRepository<T> CreateInstance<T>(DbContext context) where T : class
        {
            return new GenericRepository<T>(context);
        }
    }
}
