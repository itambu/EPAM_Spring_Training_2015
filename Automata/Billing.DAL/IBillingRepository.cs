using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Billing.DAL
{
    public interface IBillingRepository<EntityInterface> : IDisposable where EntityInterface : class, Billing.ModelInterfaces.IEntity
    {
        void Add(EntityInterface model);
        void Remove(EntityInterface model);
        void SaveChanges();
        IQueryable<EntityInterface> GetEntities();
        IQueryable<EntityInterface> GetEntities(Expression<Func<EntityInterface, bool>> predicate);
        //void Attach<OtherEntity>(OtherEntity entity) where OtherEntity : class;
        void Attach(EntityInterface entity);
        EntityInterface FirstOrDefault(Expression<Func<EntityInterface, bool>> predicate);
        EntityInterface GetById(Guid id);
    }
}
