using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private ICollection<T> _items = null;

        public CustomCollection(ICollection<T> items)
        {
            _items = items;

//            _items = new List<T>();
        }

        public CustomCollection()
        {
        }


        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public IEnumerable<T> Reverse()
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                yield return _items.ElementAt(i);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
