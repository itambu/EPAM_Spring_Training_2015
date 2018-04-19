using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.DAL.Classes.Models
{
    public class User
    {
        public User(int id, string alias)
        {
            Id = id;
            Alias = alias;
        }

        public int Id { get; set; }
        public string Alias { get; set; }
    }
}
