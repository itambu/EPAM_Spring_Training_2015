using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLib.Core;

namespace MediaLib.Core.Classes
{
    public class Track : AbstractMediaItem, Interfaces.IMediaItem
    {
        public string Album { get; set; }
        public string Path { get; private set; }

        public Track(Guid guid, string name, Enums.Rating rating, string album, string path) 
            :base(guid, name, rating)
        {
            Album = album;
            Path = path;
        }
    }

 
}

