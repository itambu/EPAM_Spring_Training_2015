using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class AudioItem : MediaItem, IAudioItem
    {
        public int Bitrate { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
