using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.BL;
using Billing.BL.BusinessEntities;
using Billing.BL.BusinessEntities.BillingPlans;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingHandler handler = new BillingHandler();

            //handler.Add( new Terminal(Guid.NewGuid(), "101"));
            //var client2 = new Client(){Id = Guid.NewGuid(), FullName = "Петя Огурцов"};
            //handler.Add( client2);
            //handler.Add( new Contract()
            //{
            //    Id = Guid.NewGuid(), 
            //    ContractStartDate = new DateTime(2016, 7, 1), 
            //    ContractCloseDate=null, 
            //    Client = client2,
            //    Terminal = handler.GetTerminals(x=>x.TerminalNumber=="101").FirstOrDefault()
            //});

            //var plan = handler.GetBillingPlans().FirstOrDefault();

            //handler.Add(new ContractBillingPlanBinding()
            //{
            //    Id = Guid.NewGuid(),
            //    Contract = handler.GetContracts(x=>x.Terminal.TerminalNumber=="000-00-0").FirstOrDefault(),
            //    BindingDate = new DateTime(2016, 7, 1),
            //    BillingPlan = plan
            //});

            //handler.Add(new ContractBillingPlanBinding()
            //{
            //    Id = Guid.NewGuid(),
            //    Contract = handler.GetContracts(x=>x.Terminal.TerminalNumber=="101").FirstOrDefault(),
            //    BindingDate = new DateTime(2016, 7, 1),
            //    BillingPlan = plan
            //});

            //var info = new CallInfo()
            //{
            //    Id = Guid.NewGuid(), 
            //    Source = handler.GetTerminals(x=>x.TerminalNumber =="000-00-0").FirstOrDefault() , 
            //    Target= handler.GetTerminals(x=>x.TerminalNumber =="101").FirstOrDefault(), 
            //    Started = new DateTime(2016, 7, 2), 
            //    Duration = new TimeSpan(0, 2, 15)
            //};
            //handler.CalculateCost(info);
            //handler.Add(info);

            //handler.Add(new Terminal(Guid.NewGuid(), "102"));
            //handler.Add(new Client() { Id = Guid.NewGuid(), FullName = "Шериф" });
            //handler.Add(new Contract()
            //{
            //    Id = Guid.NewGuid(),
            //    Terminal = handler.GetTerminals(x => x.TerminalNumber == "102").FirstOrDefault(),
            //    Client = handler.GetClients(x => x.FullName == "Шериф").FirstOrDefault(),
            //    ContractStartDate = new DateTime(2016, 7, 1),
            //    ContractCloseDate = null
            //});

            //handler.Add(new Terminal(Guid.NewGuid(), "103"));
            //handler.Add(new ContractBillingPlanBinding()
            //{
            //    Id = Guid.NewGuid(),
            //    BillingPlan = handler.GetBillingPlans().FirstOrDefault(),
            //    Contract = handler.GetContracts(x => x.Client.FullName == "Шериф").FirstOrDefault(),
            //    BindingDate = new DateTime(2016, 7, 1)
            //});

            //var c = handler.GetContracts(x => x.Client.FullName == "Шериф").FirstOrDefault() as Contract;
            //var p = handler.CloseContract(c, new DateTime(2016, 7, 2));

            var c = handler.GetContractBillingPalnBindings(x => true).FirstOrDefault();

            // new comment
            // comment

        }
    }
}
