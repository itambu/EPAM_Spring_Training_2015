using NetShop.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NetShop.Order
{
    public class BasketElement
    {
        [XmlElement(Type=typeof(Element.Element))]
        public IElement Element { get; set; }
        public double Amount { get; set; }
        public Decimal Sum { get; set; }
    }
}
