using System;
using System.Collections.Generic;
using System.Text;

namespace NetShop.Core.Interfaces
{
    public interface IOrder
    {
        IBasket Basket { get; }
        IUser User { get; }
        DateTime Created { get; }
    }
}
