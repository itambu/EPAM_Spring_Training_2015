using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class Season : ICollection<IMovieItem>
    {
        public TimeSpan Duration { get; set; }
        public DateTime CreationDate { get; set; }
        public Rating Rating { get; set; }
        public string Name { get; set; }

       // private ICollection<Mo

        public void Add(IMovieItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IMovieItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IMovieItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(IMovieItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IMovieItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
