using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediateka2
{
    public abstract class LocalizedItem : Item
    {
        public string Location { get; protected set; }

        public LocalizedItem(string location, string name) : base(name)
        {
            this.Location = location;
        }
    }
}
