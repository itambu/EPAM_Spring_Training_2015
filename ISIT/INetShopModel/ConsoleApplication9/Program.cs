using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InetShopLibrary;
using InetShopLibrary.ShopItem;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(new ShopItemGroup(new List<IShopItem>()),
                new List<IUser>(),
                new List<IManager>(),
                new List<IOrder>()
                );

            shop.Add(
                new InetShopLibrary.Users.User(
                    id: 1,
                    fullName: "Вася Козлов",
                    address: new Address()
                    ));
            shop.Add(
                new InetShopLibrary.Users.Manager(id : 1, fullName : "Петя Ослов" ));

        }
    }
}
