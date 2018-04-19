using System;
using System.Collections.Generic;
using System.Text;

namespace NetShop.Core.Interfaces
{
    public interface IBasket : ICollection<IBasketItem>
    {
        double TotalCost { get; }
    }
}
