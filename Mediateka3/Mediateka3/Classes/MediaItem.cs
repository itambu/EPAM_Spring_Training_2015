using Mediateka3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka3.Classes
{
    public class MediaItem : INameable
    {
        public string Name
        {
            get;
            private set;
        }

        public MediaItem(string name)
        {
            Name = name;
        }
    }
}
