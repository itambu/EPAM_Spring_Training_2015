using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka3.Interfaces;

namespace Mediateka3.Classes
{
    public class Picture  : MediaItem
    {
        public string Name { get; private set; }

        public System.Drawing.Size Size
        {
            get { throw new NotImplementedException(); }
        }

        public Rate Rate
        {
            get { throw new NotImplementedException(); }
        }

        public long PhysicalSize
        {
            get { throw new NotImplementedException(); }
        }

        public Picture(string name) : base(name)
        {
           
        }
    }
}
