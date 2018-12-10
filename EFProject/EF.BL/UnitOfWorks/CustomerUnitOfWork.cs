using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EF.DAL.Abstractions;
using System.Linq.Expressions;
using EF.BL.Support;

namespace EF.BL.UnitOfWorks
{
    public class CustomerUnitOfWork : GenericUnitOfWork<BL.Models.Customer, Entites.User>
    {
        public CustomerUnitOfWork(DbContext context, IRepositoryFactory repoFactory, ReaderWriterLockSlim locker)
            : base(context, repoFactory, locker)
        {
        }

        protected override Func<Models.Customer, Entites.User> ToEntity
        {
            get { return x => new Entites.User() { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName }; }
        }

        protected override Func<Entites.User, Models.Customer> ToModel
        {
            get { return x => new EF.BL.Models.Customer() { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName }; }
        }
    }
}

