using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [MaxLength(10, ErrorMessage = "Too many chars")]
        [StringLength(10, ErrorMessage = "Too many chars")]
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

        public int CommentNumber { get; set; }
    }
}