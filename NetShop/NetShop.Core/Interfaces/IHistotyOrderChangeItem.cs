using NetShop.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Core.Interfaces
{
    public interface IHistotyOrderChangeItem
    {
        IOrder Order { get; }
        DateTime TimeStamp { get; }
        OrderStatus Status { get; }
    }
}
