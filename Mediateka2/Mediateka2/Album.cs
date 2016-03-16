using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediateka2
{
    public class Album : Item, IMediaElement
    {
        public Picture Cover { get; set; }
        public List<Track> Tracks { get; protected set; }
        public DateTime Created { get; set; }

        public Album(string name, Picture cover, DateTime created, List<Track> tracks)
            : base(name)
        {
            this.Cover = cover;
            this.Created = created;
            this.Tracks = tracks;
        }

        public void Play()
        {
            Cover.Play();
            foreach (var item in this.Tracks)
            {
                item.Play();
            }
        }
    }
}
