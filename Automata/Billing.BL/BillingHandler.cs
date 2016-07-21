using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.DAL;
using Billing.ModelInterfaces;
using System.Linq.Expressions;
using Billing.ModelInterfaces.ExpressionTransformationSupport;
using Billing.BL.Interfaces;

namespace Billing.BL
{
    public class BillingHandler
    {
        public BillingHandler()
        {
        }

        public void NewCallInfoHandler(object sender, Automata.CallInfo newItem)
        {
        }

        #region Client Operations

        public void Add(IUser newUser)
        {
            var entity = Mapper.Mapper.DTOtoEntity(newUser);
            using(var repository = new ClientRepository())
            {
                repository.Add(entity);
                repository.SaveChanges();
            }
        }

        public IEnumerable<IUser> GetClients(Expression<Func<IUser, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression", "");
            }
            IEnumerable<IUser> result = null;
            using (var repository = new ClientRepository())
            {
                result = repository.GetEntities()
                    .Where(expression)
                    .ToArray()
                    .Select(x => Mapper.Mapper.EntityToDTO(x))
                    .ToArray();
            }
            return result;
        }


        public void Update(IUser client)
        {
            using (var repository = new ClientRepository())
            {
                var temp = Mapper.Mapper.DTOtoEntity(client);
                repository.Attach(temp);
                    repository.SaveChanges();
            }
        }

        #endregion

        #region BillingPlan Operations

        public void Add(IBillingPlan newPlan)
        {
            Model.BillingPlan model = new Model.BillingPlan() { Id = newPlan.Id, Calculator = newPlan };
            using (IBillingRepository<IBillingPlan> repository = new BillingPlanRepository())
            {
                repository.Add(model);
                repository.SaveChanges();
            }
        }

        public IEnumerable<IBillingPlan> GetBillingPlans(Expression<Func<IBillingPlan, bool>> expression)
        {
            //ParameterExpression sourceParameter = expression.Parameters.FirstOrDefault(x => x.Type == typeof(IBillingPlan));
            //var newExpression = Billing.BL.ExpressionTransformationSupport
            //    .ParameterTypeTransformer<IBillingPlan, Model.BillingPlan>
            //    .TransformPredicate(expression, sourceParameter);

            IEnumerable<IBillingPlan> result = null;
            using (var repository = new BillingPlanRepository())
            {
                result = repository.GetEntities(expression).ToArray().Select(x => Mapper.Mapper.EntityToDTO(x)).ToArray();
            }
            return result;
        }

        public IEnumerable<IBillingPlan> GetBillingPlans()
        {
            IEnumerable<IBillingPlan> result = null;
            using (var repository = new BillingPlanRepository())
            {
                result = repository.GetEntities().ToArray().Select(x => Mapper.Mapper.EntityToDTO(x)).ToArray();
            }
            return result;
        }
        #endregion

        #region Contract Operations
        public void Add(IContract model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model", "");
            }

            if (GetContracts(x => model.Terminal.Id == x.Terminal.Id && x.ContractCloseDate!=null).FirstOrDefault() == null)
            {
                using (var repository = new ContractRepository())
                {
                    repository.Add(Mapper.Mapper.DTOtoEntity(model));
                    repository.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentException("Terminal is used in other contract");
            }
        }

        public IEnumerable<IContract> GetContracts(Expression<Func<IContract, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression", "");
            }

            IEnumerable<IContract> result = null;
            using (var repository = new ContractRepository())
            {
                result = repository.GetEntities(expression)
                    .ToArray()
                    .Select(x => Mapper.Mapper.EntityToDTO(x))
                    .ToArray();
            }
            return result;
        }

        //public void Update(IContract contract)
        //{
        //    using (var repository = new ContractRepository())
        //    {
        //        var entity = Mapper.Mapper.DTOtoEntity(contract);
        //        repository.Attach(entity);
        //        repository.SaveChanges();
        //    }
        //}

        public IContract CloseContract(ITerminateableContract contract, DateTime closeDate)
        {
            if (contract.ContractCloseDate == null)
            {
                contract.Terminate(closeDate);
                using (var repository = new ContractRepository())
                {
                    var entity = Mapper.Mapper.DTOtoEntity(contract);
                    repository.Attach(entity);
                    repository.SaveChanges();
                }
                return GetContracts(x => x.Id == contract.Id).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Terminal Operations

        public void Add(ITerminal terminal)
        {
            using (IBillingRepository<ITerminal> repository = new TerminalRepository())
            {
                var entity = Mapper.Mapper.DTOtoEntity(terminal);
                repository.Add(entity);
                repository.SaveChanges();
            }
        }

        public IEnumerable<ITerminal> GetTerminals(Expression<Func<ITerminal, bool>> expression)
        {
            //ParameterExpression sourceParameter = expression.Parameters.FirstOrDefault(x => x.Type == typeof(ITerminal));
            //var newExpression = Billing.BL.ExpressionTransformationSupport
            //    .ParameterTypeTransformer<ITerminal, Model.Terminal>
            //    .TransformPredicate(expression, sourceParameter);
            if (expression == null)
            {
                throw new ArgumentNullException("expression", "");
            }
            IEnumerable<ITerminal> result = null;
            using (var repository = new TerminalRepository())
            {
                result = repository.GetEntities(expression)
                    .ToArray()
                    .Select(x => Mapper.Mapper.EntityToDTO(x))
                    .ToArray();
            }
            return result;
        }        
        #endregion

        #region ContractBillingPlanBinding Operations
        public void Add(IContractBillingPlanBinding binding)
        {
            var bindingModel = Mapper.Mapper.DTOtoEntity(binding);
            using (var repository = new ContractBillingPlanBindingRepository())
            {
                repository.Add(bindingModel);
                repository.SaveChanges();
            }
        }

        public IEnumerable<IContractBillingPlanBinding> GetContractBillingPalnBindings(Expression<Func<IContractBillingPlanBinding, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression", "");
            }
            IEnumerable<IContractBillingPlanBinding> result = null;
            using (var repository = new ContractBillingPlanBindingRepository())
            {
                result = repository.GetEntities(expression)
                    .ToArray()
                    .Select(x => Mapper.Mapper.EntityToDTO(x))
                    .ToArray();
            }
            return result;
        }

        #endregion

        #region CallInfo Operations
        public void Add(ICostChangeableCallInfo model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model", "");
            }
            this.CalculateCost(model);
            using (IBillingRepository<ICallInfo> repository = new CallInfoRepository())
            {
                var entity = Mapper.Mapper.DTOtoEntity(model);
                repository.Add(entity);
                repository.SaveChanges();
            }
        }

        protected IContract GetActiveContractForTerminal(ITerminal terminal, DateTime actualDate)
        {
            return GetContracts(
                    x => x.Terminal.TerminalNumber == terminal.TerminalNumber
                    && x.ContractCloseDate == null)
                   .FirstOrDefault();
        }

        protected IBillingPlan GetActiveBillingPlanForContract(IContract contract, DateTime actualDate)
        {
            if (contract == null)
            {
                throw new ArgumentException(String.Format("Contract is null"));
            }
            var binding = GetContractBillingPalnBindings(x => x.Contract.Id == contract.Id && x.BindingDate <= actualDate)
                .OrderBy(x => x.BindingDate)
                .Last();
            return binding != null ? binding.BillingPlan : null;
        }


        public void CalculateCost(ICostChangeableCallInfo callInfo)
        {
            if (callInfo == null)
            {
                throw new ArgumentNullException("Source terminal is null");
            }

            var contract = GetActiveContractForTerminal(callInfo.Source, callInfo.Started);
            if (contract == null)
            {
                    throw new ArgumentException(String.Format("No active contract is for terminal {0} on {1}", callInfo.Source.TerminalNumber, callInfo.Started));
            }

            var plan = GetActiveBillingPlanForContract(contract, callInfo.Started);
            if (plan == null)
            {
                throw new ArgumentException(String.Format("No plan is active for contract"));
            }
            
            DateTime periodStart = new DateTime(Math.Max(contract.ContractStartDate.Ticks, callInfo.Started.AddMonths(-1).Ticks));
            var previous = GetCallInfos(
                x => x.Started >= periodStart 
                && System.Data.Entity.DbFunctions.AddMilliseconds(
                    x.Started, 
                    System.Data.Entity.DbFunctions.DiffMilliseconds(x.Duration, TimeSpan.Zero)) 
                        < callInfo.Started);
            callInfo.Cost = plan.CalculateCost(callInfo, previous);
        }

        public IEnumerable<ICallInfo> GetCallInfos(Expression<Func<ICallInfo, bool>> expression)
        {
            IEnumerable<ICallInfo> result = null;
            using (var repository = new CallInfoRepository())
            {
                result = repository.GetEntities(expression)
                    .ToArray()
                    .Select(x => Mapper.Mapper.EntityToDTO(x))
                    .ToArray();
            }
            return result;
        }

        #endregion
    }
}
