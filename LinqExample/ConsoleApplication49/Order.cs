using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication49
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public ICollection<OrderedItem> Items { get; set; }
    }
}
