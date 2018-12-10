using EF.DAL.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EF.Entites.Abstractions;


namespace EF.BL
{
    public class Unity
    {
        private IDictionary<Type, ReaderWriterLockSlim> _lockers;
        private IRepositoryFactory _repositoryFactory;
        private IDbContextFactory _contextFactory;

        public Unity( )
        {
            InitializeLockers();
            _contextFactory = new Entites.Factory.BlogContextFactory();
            _repositoryFactory = new DAL.Factory.GenericRepositoryFactory();
        }

        protected virtual void InitializeLockers()
        {
            _lockers = new Dictionary<Type, ReaderWriterLockSlim>();
            _lockers.Add(typeof(Models.Customer), new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion));
        }

        public Task<bool> StartFileParse(string fileName)
        {
            return Task<bool>.Factory.StartNew(() =>
                {
                    Expression<Func<Models.Customer, bool>> customerSearchCriteria = x => x.FirstName == "aaaa" && x.LastName == "bbbb";

                    while (true)
                    {

                        using (var context = _contextFactory.CreateInstance())
                        {

                            var customerUnitOfWork = new UnitOfWorks.CustomerUnitOfWork(
                                context, _repositoryFactory, ResolveLocker(typeof(Models.Customer)));
                            
                            var customer = customerUnitOfWork.TryGet(customerSearchCriteria, true);
                            if (customer == null)
                            {
                                customer = new Models.Customer() { FirstName = "", LastName = "" };
                                customerUnitOfWork.TryAdd(customer, customerSearchCriteria, true);
                            }




                        }
                    }



                    return true;
                }
                );
        }


        protected ReaderWriterLockSlim ResolveLocker(Type modelType)
        {
            return _lockers[modelType];
        }
    }
}
