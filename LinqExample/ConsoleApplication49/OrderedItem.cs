using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication49
{
    public class OrderedItem
    {
        public Item Item { get; set; }
        public double Cost { get; set; }
        public double Quantity { get; set; }
        public double Total
        {
            get { return this.Cost * this.Quantity; }
        }
    }
}
