using EF.DAL.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EF.BL.Support;

namespace EF.BL.UnitOfWorks
{
    public abstract class GenericUnitOfWork<Model, Entity> where Entity: class where Model: class
    {
        private DbContext _context;
        private IRepositoryFactory _repoFactory;
        private ReaderWriterLockSlim _locker;
        protected abstract Func<Model, Entity> ToEntity{ get;}
        protected abstract Func<Entity, Model> ToModel { get; }

        public GenericUnitOfWork(DbContext context, IRepositoryFactory repoFactory, ReaderWriterLockSlim locker)
        {
            _context = context;
            _repoFactory = repoFactory;
            _locker = locker;
        }

        public Model TryGet(Expression<Func<Model, bool>> searchExpression, bool safeMode = false) 
        {
            var entityRepository = _repoFactory.CreateInstance<Entity>(_context);

            var newExpression = searchExpression.Project<Model, Entity>();

            if (safeMode)
            {
                _locker.EnterReadLock();
            }
            Entity user = null;
            try
            {
                user = entityRepository.Get().FirstOrDefault(newExpression);
                return user != null ? ToModel.Invoke(user) : null;
            }
            finally
            {
                if (safeMode)
                {
                    _locker.ExitReadLock();
                }
            }
        }
        public void TryAdd(Model customer, Expression<Func<Model, bool>> searchExpression, bool requiredBlocking)
        {
            if (requiredBlocking) _locker.EnterWriteLock();
            try
            {
                if (TryGet(searchExpression) == null)
                {
                    var userRepository = _repoFactory.CreateInstance<Entity>(_context);
                    userRepository.Add(ToEntity(customer));
                    userRepository.Save();
                }
            }
            finally
            {
                if (requiredBlocking) _locker.ExitWriteLock();
            }
        }

    }
}
