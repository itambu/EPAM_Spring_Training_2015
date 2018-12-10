using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DAL.Abstractions
{
    public interface IRepositoryFactory 
    {
        IGenericRepository<T> CreateInstance<T>(DbContext context) where T : class;
    }
}
