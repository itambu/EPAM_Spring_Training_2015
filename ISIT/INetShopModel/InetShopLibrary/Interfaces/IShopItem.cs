using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InetShopLibrary
{
    public interface IShopItem
    {
        int Id { get; }
        string Name { get; }
    }
}
