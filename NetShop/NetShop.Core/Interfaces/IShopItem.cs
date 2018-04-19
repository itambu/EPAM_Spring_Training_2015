using System;
using System.Collections.Generic;
using System.Text;

namespace NetShop.Core.Interfaces
{
    public interface IShopItem
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
    }
}
