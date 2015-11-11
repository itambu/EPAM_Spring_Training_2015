using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.Basket
{
    public class Basket : IBasket
    {
        private ICollection<IBasketItem> _items;
        public IEnumerable<IBasketItem> Items
        {
            get { return _items; }
        }

        public double Sum
        {
            get 
            {
                return (Items != null) ? Items.Sum(x => x.Sum) : 0;
            }
        }

        public Basket(ICollection<IBasketItem> source)
        {
            this._items = source;
        }

        public void Add(IBasketItem newItem)
        {
            if (_items != null && newItem != null)
            {
                _items.Add(newItem);
            }
        }

        public void Remove(IBasketItem item)
        {
            if (_items != null && item != null)
            {
                _items.Remove(item);
            }
        }
    }
}
