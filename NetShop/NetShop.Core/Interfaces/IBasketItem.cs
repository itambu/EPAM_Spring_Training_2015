using System;
using System.Collections.Generic;
using System.Text;

namespace NetShop.Core.Interfaces
{
    public interface IBasketItem
    {
        IShopItem Item { get; }
        double  TotalCost { get; }
        double Amount { get; } 
    }
}
