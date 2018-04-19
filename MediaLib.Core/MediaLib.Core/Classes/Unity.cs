using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Classes
{
    public class Unity
    {
        private ICollection<Interfaces.IPlayList> _items;

        public Unity(ICollection<Interfaces.IPlayList> items)
        {
            _items = items;
        }

    }
}
