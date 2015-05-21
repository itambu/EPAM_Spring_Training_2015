using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemList = new List<Item>()
            {
                new Item(){Name="Вилы", Description="Двухстронние"},
                new Item(){Name="Грабли", Description="Одностороние"},
                new Item(){Name="Фуфайки", Description="Летние"}
            };

            List<Order> orderList = new List<Order>()
            {
                new Order()
                {
                    OrderDate=new DateTime(2015, 5, 10),
                    Items = new List<OrderedItem>()
                    {
                        new OrderedItem()
                        {
                            Item = itemList[0],
                            Cost = 10,
                            Quantity = 10
                        },
                        new OrderedItem()
                        {
                            Item = itemList[2],
                            Cost = 5,
                            Quantity = 200
                        }
                    }
                },
                new Order()
                {
                    OrderDate=new DateTime(2015, 5, 11),
                    Items = new List<OrderedItem>()
                    {
                        new OrderedItem()
                        {
                            Item = itemList[1],
                            Cost = 20,
                            Quantity = 10
                        },
                        new OrderedItem()
                        {
                            Item = itemList[2],
                            Cost = 10,
                            Quantity = 100
                        }
                    }
                },
                new Order()
                {
                    OrderDate=new DateTime(2015, 5, 10),
                    Items = new List<OrderedItem>()
                    {
                        new OrderedItem()
                        {
                            Item = itemList[0],
                            Cost = 12,
                            Quantity = 12
                        },
                        new OrderedItem()
                        {
                            Item = itemList[1],
                            Cost = 30,
                            Quantity = 10
                        }
                    }
                }

            };

            //-------------------------------------------
            var iterator = orderList.SelectMany(
                x => x.Items.Select(z => 
                    new {ItemDate=x.OrderDate, 
                        Name = z.Item.Name, 
                        Cost = z.Cost, 
                        Quantity = z.Quantity, 
                        Total = z.Total })
                )
                //.ForAll(x=>x.ToString())
                //.Select(x => new { Name = x.Item.Name, Total = x.Total })
                ;
                //.ForAll(x => String.Format("Name={0} Cost={1} Quantity={2} Total={3}", x.Item.Name, x.Cost, x.Quantity, x.Total));



            var g = from x in iterator
                    group x by x.Name //new { Name = x.Name, ItemDate = x.ItemDate }
                        into gr
                        join y in itemList on gr.Key equals y.Name
                        select new { 
                            Name = gr.Key, 
                            Description=y.Description, 
                            Total = gr.Sum(x => x.Total) 
                        }; 
            g.ForAll(x => x.ToString());

            iterator.ForAll(x => String.Format("Name={0} Total={1}", x.Name, x.Total));

            Console.WriteLine(iterator.Sum(x => x.Total));
        }
    }
}
