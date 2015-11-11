using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.ShopItem
{
    public class ShopItemGroup : ShopItem, IShopItem, IShopItemGroup
    {
        #region ICollection
        ICollection<IShopItem> _items;

        public ShopItemGroup(ICollection<IShopItem> source) 
        {
            this._items = source;
        }

        private bool ValidateInternalCollection()
        {
            return this._items != null;
        }

        public void Add(IShopItem item)
        {
            if (ValidateInternalCollection())
            {
                _items.Add(item);
            }
        }

        public void Clear()
        {
            if (ValidateInternalCollection())
            {
                _items.Clear();
            }
        }

        public bool Contains(IShopItem item)
        {
            if (ValidateInternalCollection())
            {
                return _items.Contains(item);
            }
            else
                return false;
        }

        public void CopyTo(IShopItem[] array, int arrayIndex)
        {
            if (ValidateInternalCollection())
            {
                _items.CopyTo(array, arrayIndex);
            }
        }

        public int Count
        {
            get { return ValidateInternalCollection() ? _items.Count: 0; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(IShopItem item)
        {
            return (ValidateInternalCollection()) ? _items.Remove(item) : false;
        }

        public IEnumerator<IShopItem> GetEnumerator()
        {
            return (ValidateInternalCollection()) ? _items.GetEnumerator() : null;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
