using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    
    /// <summary>
    /// 
    /// </summary>
    public class Basket : ICollection<BasketElement>
    {
        public Basket(ICollection<BasketElement> items)
        {
            _items = items;
        }

        private ICollection<BasketElement> _items;

        /// <summary>
        /// 
        /// </summary>
        public Decimal Sum
        {
            get
            {
                if (_items != null)
                {
                    return _items.Sum(x => x.Sum);
                }
                else
                {
                    throw new NullReferenceException("Items cannot be null");
                }
            }
        }

        public void Add(BasketElement item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(BasketElement item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(BasketElement[] array, int arrayIndex)
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

        public bool Remove(BasketElement item)
        {
            return _items.Remove(item);
        }

        public IEnumerator<BasketElement> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
