using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Classes
{
    public class Unity
    {
        private ICollection<Interfaces.IPlayList> _playListCollection;
        private ICollection<Interfaces.IMediaItem> _itemCollection;

        public Unity(ICollection<Interfaces.IPlayList> playListCollection, ICollection<Interfaces.IMediaItem>  itemCollection)
        {
            _playListCollection = playListCollection;
            _itemCollection = itemCollection;
        }

        public void Add(Interfaces.IMediaItem item)
        {
            //Validate(item);
            //-----------------------------------
            _itemCollection.Add(item);
        }

        //public void partial Validate(Interfaces.IMediaItem item);

        public void Add(Interfaces.IPlayList list, Interfaces.IMediaItem item)
        {
            list.Add(item);
        }

    }
}
