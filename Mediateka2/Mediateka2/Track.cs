using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediateka2
{
    public class Track : LocalizedItem, IMediaElement, IHasLocation
    {
        public TimeSpan Duration { get; set; }
        public Track(string location, string name, TimeSpan duration)
            : base(name: name, location: location)
        {
            this.Duration = duration;
        }

        public void Play()
        {
            // play track in mediaplayer
        }
    }
}
