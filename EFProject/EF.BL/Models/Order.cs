using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.BL.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public Manager Manager { get; private set; }
        public Customer Customer { get; private set; }
    }
}
