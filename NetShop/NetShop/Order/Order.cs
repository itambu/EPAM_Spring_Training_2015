using NetShop.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    public class Order : IOrder
    {
        private Basket _basket;
        public Basket Basket
        {
            get { return _basket; }
        }

        public decimal Sum
        {
            get { return _basket.Sum; }
        }

        public User.IUser User
        {
            get;
            set;
        }

        private DateTime _orderDate;
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate != value)
                {
                    _orderDate = value;
                    OnPropertyChanged(this, new PropertyChangedEventArgs(this.GetType().GetProperty("OrderDate").Name));
                }
            }
        }

        private OrderStatus _status;
        public OrderStatus Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged(this, new PropertyChangedEventArgs(this.GetType().GetProperty("Status").Name));
                }
            }
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var temp = PropertyChanged;
            if (temp != null)
            {
                temp(sender, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Order(IUser user, Basket basket, DateTime orderDate, OrderStatus status)
        {
            User = user;
            _basket = basket;
            _orderDate = orderDate;
            _status = status;
        }

        public Order()
        {
        }

        public void Add(Element.IElement element, Decimal sum, Double amount)
        {
            Basket.Add(new BasketElement() { Element = element, Sum = sum, Amount = amount });
        }

        public void Remove(BasketElement element)
        {
            throw new NotImplementedException();
        }


        public void Add(Element.IElement element)
        {
            throw new NotImplementedException();
        }

        public void Remove(Element.IElement element)
        {
            throw new NotImplementedException();
        }
    }
}
