using Blog.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BL.Classes
{
    public class User : IUser
    {
        public int Id
        {
            get;
            set;
        }

        public string Alias
        {
            get;
            set;
        }

        public Entities.Contact Contact
        {
            get;
            set;
        }
    }
}
