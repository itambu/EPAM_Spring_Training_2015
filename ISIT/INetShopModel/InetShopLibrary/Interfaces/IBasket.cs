using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InetShopLibrary
{
    public interface IBasket
    {
        IEnumerable<IBasketItem> Items { get; }
        double Sum { get; }

        void Add(IBasketItem newItem);
        void Remove(IBasketItem item);
    }
}
