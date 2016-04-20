using NetShop.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using NetShop.Element;
using NetShop.Order;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(new List<IElement>(), new List<IOrder>());
            CustomShopBuilder builder = new CustomShopBuilder(shop);
            builder.Build();

            //
            XmlSerializer serializer = new XmlSerializer(typeof(Order));
            Order order = new Order(null, new Basket(new List<BasketElement>()), DateTime.Now, OrderStatus.Open);
            using (var stream = new FileStream(@"d:\myxml.xml", FileMode.Create))
            {
                serializer.Serialize(stream, shop);
            }
            //

        }
    }
}
