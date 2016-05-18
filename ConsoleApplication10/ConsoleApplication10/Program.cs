using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            //var q = from x in list 
            //        where x % 2 == 0 
            //        select x;

            //var q1 = list
            //    .Where(x => x % 2 == 0)
            //    .Select(x => x)
            //    .ToConsole(x => String.Format("{0}", x));

            //try
            //{
            //    var q2 = list.First(x => x == 6);
            //}
            //catch (InvalidOperationException e)
            //{
            //    //
            //}

            //var q3 = list.FirstOrDefault(x => x == 6);

            //var q4 = list
            //    .Select(x => new { Item = 3, Square = x * x })
            //    .ToConsole(x => String.Format("{0}", x));
            //var q5 = q4.ToConsole(x => x.Square.ToString());

            ////int c = 0;
            //var q6 = list.Aggregate(0, (seed, x) => seed + x);

            var userList = new List<User>(){
                new User(){Id=1, FirstName="John"},
                new User(){Id=2, FirstName="Mary"}
            };

            var orderList = new List<Order>(){
                new Order(){Id=1, UserId = 1, OrderDate=new DateTime(2016, 12, 1), Sum =100}, 
                new Order(){Id=2, UserId = 2, OrderDate=new DateTime(2016, 12, 2), Sum =200}, 
                new Order(){Id=3, UserId = 1, OrderDate=new DateTime(2016, 12, 3), Sum =150}, 
                new Order(){Id=4, UserId = 2, OrderDate=new DateTime(2016, 12, 4), Sum =180}, 
                new Order(){Id=5, UserId = 2, OrderDate=new DateTime(2016, 12, 5), Sum =110} 
            };

            //var q1 = from x in orderList
            //         join y in userList on x.UserId equals y.Id
            //         select new { OrderDate = x.OrderDate, UserName = y.FirstName };
            //q1.ToConsole(x => x.ToString());



            orderList.Join(userList, x => x.UserId, x => x.Id, 
                (x, y) => new { OrderDate = x.OrderDate, UserName = y.FirstName }, 
                EqualityComparer<int>.Default)
                .ToConsole(x => x.ToString());

            var q1 = from x in orderList
                     join y in userList on x.UserId equals y.Id
                     group new { UserName = y.FirstName, OrderDate = x.OrderDate, Id = x.Id, Sum = x.Sum } by x.UserId
                         into g
                         select new {UserName=g.Key, Sum= g.Sum(x => x.Sum)};

            var q2 = orderList.GroupBy(x=>x.UserId)
                              .Join(userList, 
                                    g=>g.Key, 
                                    y=>y.Id, 
                                    (x,y)=> new {UserName=y.FirstName, Sum = x.Sum(z=>z.Sum) }
                                   );
            q2.ToConsole(x => x.ToString());



            //var q1 = orderList.GroupBy(x => x.UserId);

            //foreach (var c in q1)
            //{
            //    c.ToConsole(x => String.Format("{0} {1} {2}", x.Id, x.UserName, x.OrderDate));
            //}

        }
    }
}
