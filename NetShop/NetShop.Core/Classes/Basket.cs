using NetShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Core.Classes
{
    public class Basket : NetShop.Core.Interfaces.IBasket 
    {
        private ICollection<Interfaces.IBasketItem> _items;

        public Basket(ICollection<IBasketItem> items)
        {
            _items = items;
        }

        public Basket()
        {
        }

        public double TotalCost
        {
            get { return _items.Sum(x => x.TotalCost); }
        }

        public void Add(Interfaces.IBasketItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(Interfaces.IBasketItem item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(Interfaces.IBasketItem[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public bool IsReadOnly
        {
            get { return _items.IsReadOnly; }
        }

        public bool Remove(Interfaces.IBasketItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            return _items.Remove(item);
        }

        public IEnumerator<Interfaces.IBasketItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
