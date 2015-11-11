using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.ShopItem
{
    public class ShopItem : IShopItem
    {
        public int Id
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }
    }
}
