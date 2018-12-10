using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Display(Name = "Description")]
        [DisplayFormat(NullDisplayText="empty")]
        public string Description{ get; set;}
    }
}