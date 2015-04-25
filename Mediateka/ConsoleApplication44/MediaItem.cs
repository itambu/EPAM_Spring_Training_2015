using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public abstract class MediaItem : IMediaItem
    {
        public DateTime CreationDate { get; set; }
        public Rating Rating { get; set; }
        public string Name{ get; set; }
    }
}
