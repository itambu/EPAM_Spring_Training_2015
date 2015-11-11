using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InetShopLibrary
{
    public interface IBasketItem
    {
        IShopItem Item { get; }
        double CostPerItem { get; }
        double Qauntity { get; }
        double Sum { get; }
    }
}
