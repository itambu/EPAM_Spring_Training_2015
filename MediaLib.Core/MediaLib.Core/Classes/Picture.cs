using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Classes
{
    public class Picture : Interfaces.IMediaItem, Interfaces.ISizeable
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Enums.Rating Rating
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Size Size
        {
            get { throw new NotImplementedException(); }
        }
    }
}
