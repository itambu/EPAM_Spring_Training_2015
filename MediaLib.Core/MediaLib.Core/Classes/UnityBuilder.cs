using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Classes
{
    public class UnityBuilder
    {
        private Classes.Unity _unity;

        public UnityBuilder(ICollection<Interfaces.IMediaItem> itemCollection, ICollection<Interfaces.IPlayList> playListCollection)
        {
            _unity = new Unity(playListCollection, itemCollection);
        }

        protected void CreateItems()
        {
            _unity.Add( new Track(Guid.NewGuid(), 
                "Shine On Crazy Diamond", 
                Enums.Rating.ThreeStar,
                "", @"d:\" ) );
        }

        protected void CreatePlayLists()
        {

        }

        protected void FillPlayLists()
        {
        }

        public Classes.Unity Build()
        {
            CreateItems();
            CreatePlayLists();
            FillPlayLists();
            return _unity;
        }
    }
}
