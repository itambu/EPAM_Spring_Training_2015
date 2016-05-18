using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public double Sum { get; set; }
    }
}
