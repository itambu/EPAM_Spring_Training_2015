using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.Order
{
    public class Order : IOrder
    {
        public Order(int id, IBasket basket, IUser user, IManager respPerson, Address address)
        {
            this.Id = id;
            this.Basket = basket;
            this.TargetUser = user;
            this.ResponsablePerson = respPerson;
            this.DeliveryAddress = address;
        }

        public int Id
        {
            get;
            protected set;
        }

        public IBasket Basket
        {
            get;
            protected set;
        }

        public IUser TargetUser
        {
            get;
            protected set;
        }

        public IManager ResponsablePerson
        {
            get;
            protected set;
        }

        public double Total
        {
            get;
            protected set;
        }

        public Address DeliveryAddress
        {
            get;
            protected set;
        }

        public void AddItemToBasket(IBasketItem newItem)
        {
            Basket.Add(newItem);
            Discount();
        }

        public void DeleteItemFromBasket(IBasketItem item)
        {
            Basket.Remove(item);
            Discount();
        }

        protected virtual void Discount()
        {
            var tempTotal = this.Basket.Sum;
            this.Total = (tempTotal > 1000000) ? this.Basket.Sum * 0.9 : tempTotal;
        }

    }
}
