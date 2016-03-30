using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //var numQuery =
            //    from r in numbers
            //    where r % 2 == 0
            //    select 3 * r;

            //var numQuery1 = numbers.Where(r => r % 2 == 0).Select(r => 3 * r);

            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0,1} ", num);
            //}

            var users = new List<User>(){
                new User(){Id=1, Name="John"},
                new User(){Id=2, Name="Mary"},
                new User(){Id=3, Name="Nash"},
                new User(){Id=4, Name="Linda"}
            };

            var orders = new List<Order>()
            {
                new Order(){Id=1, OrderType=OrderType.Corporate, UserId=2, Sum=100}, 
                new Order(){Id=2, OrderType=OrderType.Corporate, UserId=1, Sum=200}, 
                new Order(){Id=3, OrderType=OrderType.Private, UserId=2, Sum=150}, 
                new Order(){Id=4, OrderType=OrderType.Private, UserId=3, Sum=100}, 
                new Order(){Id=5, OrderType=OrderType.Corporate, UserId=1, Sum=300}, 
                new Order(){Id=6, OrderType=OrderType.Corporate, UserId=4, Sum=500}, 
            };

            var q1 = (from x in orders
                     join y in users on x.UserId equals y.Id
                     select new { OrderId = x.Id, UserName = y.Name });

            var q2 = orders.Join(
                users,
                order => order.UserId,
                user => user.Id,
                (order, user) => new { OrderId = order.Id, UserName = user.Name, OrderSum=order.Sum }
                    ).ToConsole(x => String.Format("{0} {1}", x.OrderId, x.UserName));

            string s=null;
            Console.WriteLine(
                q2.Aggregate(s, 
                (seed, item) => String.Concat(seed, item.UserName)
                ));

            var q4 = (from x in q2
                      group x by x.UserName
                          into g
                          select new { UserName = g.Key, Sum = g.Sum(y => y.OrderSum) }).
                         ToConsole(x => x.ToString()).ToList();







            //q1.ToConsole(x => String.Format("{0} {1}", x.OrderId, x.UserName));
        }
    }
}
