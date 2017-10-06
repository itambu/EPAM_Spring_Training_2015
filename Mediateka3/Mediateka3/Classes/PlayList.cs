using Mediateka3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka3.Classes
{
    public class PlayList : MediaItem, IPlayList
    {

        public TimeSpan Duration
        {
            get { throw new NotImplementedException(); }
        }

        public ICollection<IMediaItem> Items
        {
            get;
            private set;
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public PlayList(string name, ICollection<IMediaItem> items)
            : base(name)
        {
            Items = items;
        }
    }
}
