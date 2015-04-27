using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class Mediateka : ICollection<IMediaItem>
    {
        private ICollection<IMediaItem> mediaItems = new List<IMediaItem>();

        #region ICollection<IMediaItem>
        public void Add(IMediaItem item)
        {
            mediaItems.Add(item);
        }

        public void Clear()
        {
            mediaItems.Clear();
        }

        public bool Contains(IMediaItem item)
        {
            return mediaItems.Contains(item);
        }

        public void CopyTo(IMediaItem[] array, int arrayIndex)
        {
            mediaItems.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return mediaItems.Count; }
        }

        public bool IsReadOnly
        {
            get { return mediaItems.IsReadOnly; }
        }

        public bool Remove(IMediaItem item)
        {
            return mediaItems.Remove(item);
        }

        public IEnumerator<IMediaItem> GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        protected void Sort(IComparer<IMediaItem> comparer)
        {
           var newList = mediaItems.ToList();
           newList.Sort(comparer);
           mediaItems = newList;
        }

        public void SortByCreationDate()
        {
            this.Sort( new MediaItemComparerByCreationDate() );
        }

        public IEnumerable<IMediaItem> GetMediaItems(DateTime startDate, DateTime endDate)
        {
            foreach (var i in mediaItems)
            {
                if (i.CreationDate >= startDate && i.CreationDate <= endDate)
                {
                    yield return i;
                }
            }
        }
    }
}
