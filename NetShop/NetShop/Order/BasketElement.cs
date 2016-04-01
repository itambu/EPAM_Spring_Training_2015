using NetShop.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    public class BasketElement
    {
        public IElement Element { get; set; }
        public double Amount { get; set; }
        public Decimal Sum { get; set; }
    }
}
