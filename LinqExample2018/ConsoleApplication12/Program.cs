using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>()
            {
                new User(){Id=1, Name="John"},
                new User(){Id = 2, Name="Martha"},
                new User(){Id = 3, Name = "Nik"}
            };

            List<Item> itemList = new List<Item>()
            {
                new Item(){Id = 1, Name = "Cow"},
                new Item(){Id = 2, Name = "Chiken"},
                new Item(){Id = 3, Name = "Duck"}
            };

            List<Order> orderList = new List<Order>()
            {
                new Order(){Id =1, ItemId = 1, UserId = 1},
                new Order(){Id =2, ItemId = 3, UserId = 2},
                new Order(){Id =3, ItemId = 2, UserId = 2},
                new Order(){Id =4, ItemId = 3, UserId = 2},
                new Order(){Id =5, ItemId = 3, UserId =2 },
                new Order(){Id =6, ItemId = 1, UserId = 1},
                new Order(){Id =7, ItemId = 3, UserId =2 },
                new Order(){Id =8, ItemId = 2, UserId = 1},
                new Order(){Id =9, ItemId = 2, UserId = 2},
                new Order(){Id =10, ItemId = 1, UserId =1 }
            };


            //------------------------------------------------------

            var q = orderList.Select(x => x.UserId).Distinct()
                    .Join(userList, x=>x, y=>y.Id, (x,y)=>y.Name)
                .Foreach(x => x.ToString());

            var q1 = from x in orderList
                     group x by x.UserId;

            var q2 = orderList.GroupBy(x => x.UserId)
                .Join(
                    userList,
                    g => g.Key, 
                    y => y.Id,
                    (g, x) => new { Name = x.Name, Count = g.Count() })
                    .Foreach(x => x.ToString());
 



        }

        public static IEnumerable<T> Foreach<T>(this IEnumerable<T> iterator, Func<T, string> transformToString)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(transformToString(item));
            }
            return iterator;
        }
    }
}
