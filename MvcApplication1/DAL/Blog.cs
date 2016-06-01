using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Blog
    {
        public int Id { get; set; }
        

        
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
