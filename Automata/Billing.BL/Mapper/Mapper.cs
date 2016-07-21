using Billing.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Billing.Model;

namespace Billing.BL.Mapper
{
    public static class Mapper
    {
        public static IBillingPlan EntityToDTO(IBillingPlan source)
        {
            PropertyInfo info = source.GetType().GetProperty("Calculator");
            var nestedIntefaceObj = info.GetValue(source, BindingFlags.NonPublic, null, null, null);
            return nestedIntefaceObj as IBillingPlan;
        }

        public static IBillingPlan DTOtoEntity(IBillingPlan source)
        {
            return new BillingPlan() { Id = source.Id, Calculator = source };
        }

        public static IUser DTOtoEntity(IUser source)
        {
            return new Client() { Id = source.Id, FullName = source.FullName };
        }

        public static IUser EntityToDTO(IUser source)
        {
            return new Billing.BL.BusinessEntities.Client() { Id = source.Id, FullName = source.FullName };
        }

        public static IContract DTOtoEntity(IContract contract)
        {
            return new Contract()
            {
                Id = contract.Id,
                ContractStartDate = contract.ContractStartDate,
                ContractCloseDate = contract.ContractCloseDate,
                Client = DTOtoEntity(contract.Client) as Client,
                Terminal = DTOtoEntity(contract.Terminal) as Terminal
            };
        }

        public static IContract EntityToDTO(IContract contract)
        {
            return new BL.BusinessEntities.Contract()
                     {
                         Id = contract.Id,
                         Terminal = EntityToDTO(contract.Terminal),
                         Client = new BL.BusinessEntities.Client() { Id = contract.Client.Id, FullName = contract.Client.FullName },
                         ContractStartDate = contract.ContractStartDate,
                         ContractCloseDate = contract.ContractCloseDate
                     };
        }

        public static ITerminal DTOtoEntity(ITerminal terminal)
        {
            return new Terminal() { Id = terminal.Id, TerminalNumber = terminal.TerminalNumber };
        }

        public static ITerminal EntityToDTO(ITerminal terminal)
        {
            return new Billing.BL.BusinessEntities.Terminal(terminal.Id, terminal.TerminalNumber);
        }

        public static IContractBillingPlanBinding DTOtoEntity(IContractBillingPlanBinding binding)
        {
            return new ContractBillingPlanBinding() { 
                Id = binding.Id, 
                Contract = DTOtoEntity(binding.Contract) as Contract, 
                BillingPlan= DTOtoEntity(binding.BillingPlan) as BillingPlan,
                BindingDate = binding.BindingDate
            };
        }

        public static IContractBillingPlanBinding EntityToDTO(IContractBillingPlanBinding binding)
        {
            return new Billing.BL.BusinessEntities.ContractBillingPlanBinding()
            {
                Id = binding.Id,
                Contract = EntityToDTO(binding.Contract),
                BillingPlan = EntityToDTO(binding.BillingPlan),
                BindingDate = binding.BindingDate
            };
        }

        public static ICallInfo DTOtoEntity(ICallInfo info)
        {
            return new CallInfo()
            {
                Id = info.Id,
                Source = DTOtoEntity(info.Source) as Terminal,
                Target = DTOtoEntity(info.Target) as Terminal,
                Started = info.Started,
                Duration = info.Duration,
                Cost = info.Cost                
            };
        }

        public static ICallInfo EntityToDTO(ICallInfo info)
        {
            return new Billing.BL.BusinessEntities.CallInfo()
            {
                Id = info.Id,
                Source = EntityToDTO(info.Source),
                Target = EntityToDTO(info.Target),
                Started = info.Started,
                Duration = info.Duration,
                Cost = info.Cost
            };
        }
    }
}
