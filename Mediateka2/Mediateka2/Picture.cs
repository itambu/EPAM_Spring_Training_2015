using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediateka2
{
    public class Picture : LocalizedItem, IMediaElement, IHasLocation
    {
        public new string Name 
        { 
            get { return "Track: " + base.Name; } 
        } 
        
        public PictureProperty Properties { get; set; }

        public Picture(string location, string name, PictureProperty properties) : base(location, name)
        {
            this.Properties = properties;
        }

        public void Play()
        {
            // show picture
        }
    }
}
