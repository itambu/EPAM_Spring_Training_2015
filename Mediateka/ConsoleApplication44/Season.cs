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

        private ICollection<IMovieItem> items = new List<IMovieItem>();

        public void Add(IMovieItem item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(IMovieItem item)
        {
            return items.Contains(item);
        }

        public void CopyTo(IMovieItem[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public bool IsReadOnly
        {
            get { return items.IsReadOnly; }
        }

        public bool Remove(IMovieItem item)
        {
            return items.Remove(item);
        }

        public IEnumerator<IMovieItem> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
