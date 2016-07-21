using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.Model;
using Billing.ModelInterfaces;

namespace Billing.DAL
{
    public abstract class BillingRepository<EntityInterface, EntityModel> : IBillingRepository<EntityInterface> 
        where EntityModel: class, EntityInterface 
        where EntityInterface : class, IEntity
    {
        protected BillingModelContainer _dataContext;

        protected virtual void ValidateDataContext()
        {
            if (_dataContext == null)
            {
                throw new NullReferenceException("Repository is disposed");
            }
        }

        public BillingRepository()
        {
            _dataContext = new BillingModelContainer();
        }

        public BillingRepository(System.Data.Common.DbConnection connection)
        {
            _dataContext = new BillingModelContainer(connection);
        }

        public void Add(EntityInterface model)
        {
            if (model != null)
            {
                ValidateDataContext();
                //AttachEntityProperties(model);
                AttachInnerEntities(model);
                _dataContext.Set<EntityModel>().Add(model as EntityModel);
            }
            else
            {
                throw new NullReferenceException("Parameter model is null");
            }
        }

//        protected abstract void AttachEntityProperties(EntityInterface model);

        public void Remove(EntityInterface model)
        {
            if (model != null)
            {
                ValidateDataContext();
                _dataContext.Set<EntityModel>().Remove(model as EntityModel);
            }
            else
            {
                throw new NullReferenceException("Parameter model is null");
            }
        }

        public void SaveChanges()
        {
            ValidateDataContext();
            _dataContext.SaveChanges();
        }

        public IQueryable<EntityInterface> GetEntities()
        {
            ValidateDataContext();
            return _dataContext.Set<EntityModel>();
        }

        public void Dispose()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
                _dataContext = null;
            }
        }

        ~BillingRepository()
        {
            Dispose();
        }

        public void Attach(EntityInterface entity)
        {
            ValidateDataContext();
            _dataContext.Set<EntityModel>().Attach(entity as EntityModel);
            _dataContext.Entry<EntityModel>(entity as EntityModel).State = System.Data.Entity.EntityState.Modified;
        }

        public IQueryable<EntityInterface> GetEntities(System.Linq.Expressions.Expression<Func<EntityInterface, bool>> predicate)
        {
            ValidateDataContext();
            return _dataContext.Set<EntityModel>().Where(predicate);
        }

        public EntityInterface FirstOrDefault(System.Linq.Expressions.Expression<Func<EntityInterface, bool>> predicate)
        {
            return GetEntities().FirstOrDefault(predicate);
        }

        public EntityInterface GetById(Guid id)
        {
            return FirstOrDefault(x=>x.Id == id);
        }

        protected void AttachInnerEntities(EntityInterface model)
        {
            var dbSets = _dataContext.GetType().GetProperties()
                .Where(x=>x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition()==typeof(System.Data.Entity.DbSet<>))
                .ToArray();

            var res = model.GetType()
                .GetProperties( System.Reflection.BindingFlags.Public |System.Reflection.BindingFlags.Instance).Join(
                    dbSets,
                    y => y.PropertyType,
                    x => x.PropertyType.GetGenericArguments().FirstOrDefault(),
                    (propInfo, gerericArg) => propInfo);
            foreach (System.Reflection.PropertyInfo p in res)
            {
                _dataContext.Set(p.PropertyType).Attach(p.GetValue(model)); 
            }
        }
    }
}
