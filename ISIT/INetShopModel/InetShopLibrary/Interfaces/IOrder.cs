using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InetShopLibrary
{
    public interface IOrder
    {
        int Id{get;}
        IBasket Basket { get; }
        IUser TargetUser { get; }
        IManager ResponsablePerson { get; }
        double Total { get; }
        Address DeliveryAddress { get; }

        void AddItemToBasket(IBasketItem newItem);
        void DeleteItemFromBasket(IBasketItem item);
    }
}
