using Mediateka3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka3.Classes
{
    public class DiskPicture : Picture , IPicture, IDiskItem
    {

        public System.IO.StreamReader MediaStream
        {
            get { throw new NotImplementedException(); }
        }

        public string Path
        {
            get;
            private set;
        }
    }
}
