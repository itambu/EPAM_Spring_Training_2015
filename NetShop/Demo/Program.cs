using NetShop.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            CustomShopBuilder builder = new CustomShopBuilder(shop);
            builder.Build();


        }
    }
}
