using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLib.Core;

namespace MediaLib.Core.Classes
{
    public abstract class AbstractMediaItem
    {
        public AbstractMediaItem(Guid id, string name, Enums.Rating rating)
        {
            Id = id;
            Name = name;
            Rating = rating;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            set;
        }

        public Enums.Rating Rating
        {
            get;
            set;
        }
    }
}
