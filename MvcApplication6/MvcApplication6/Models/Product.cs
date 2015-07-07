using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication6.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Description { get; set; }
        public DateTime Appeared { get; set; }
    }
}