using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class MediaItemComparerByCreationDate : IComparer<IMediaItem>
    {
        public int Compare(IMediaItem x, IMediaItem y)
        {
            if (x != null && y != null)
            {
                if (x.CreationDate > y.CreationDate)
                {
                    return 1;
                }
                else
                {
                    return (x.CreationDate == y.CreationDate) ? 0 : -1;
                }
            }
            else
            {
                return (y == null && x == null) ? 0 : (x != null) ? 1 : -1;
            }
        }
    }
}
