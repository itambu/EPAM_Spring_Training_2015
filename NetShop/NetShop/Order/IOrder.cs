using NetShop.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    public interface IOrder
    {
        Basket Basket { get; }
        Decimal Sum { get; }
        IUser User { get; }
        DateTime OrderDate { get; }
        OrderStatus Status { get; }
    }
}
