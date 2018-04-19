using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class CustomCollection //: IEnumerable<int>
    {
        private ICollection<int> _collection;

        public CustomCollection(ICollection<int> _sourceCollection)
        {
            _collection = _sourceCollection;
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = _collection.Count - 1; i >= 0; i--)
            {
                yield return _collection.ElementAt(i);
            }
        }

        public IEnumerable<int> Revers()
        {
            for (int i = _collection.Count - 1; i >= 0; i--)
            {
                yield return _collection.ElementAt(i);
            }
        }

        //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}
    }
}
