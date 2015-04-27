using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class Serial : Movie, ICollection<Season>, IMediaItem
    {
        private ICollection<Season> seasons = new List<Season>();

        public new TimeSpan Duration
        {
            get { return seasons.Aggregate(new TimeSpan(0, 0, 0), (seed, x) => seed + x.Duration); }
            set { new InvalidOperationException("Deprecated"); }
        }

        public void Add(Season item)
        {
            seasons.Add(item);
        }

        public void Clear()
        {
            seasons.Clear();
        }

        public bool Contains(Season item)
        {
            return seasons.Contains(item);
        }

        public void CopyTo(Season[] array, int arrayIndex)
        {
            seasons.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return seasons.Count; }
        }

        public bool IsReadOnly
        {
            get { return seasons.IsReadOnly; }
        }

        public bool Remove(Season item)
        {
            return seasons.Remove(item);
        }

        public IEnumerator<Season> GetEnumerator()
        {
            return seasons.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
