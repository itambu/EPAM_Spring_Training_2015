using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.Users
{
    public class BaseUser
    {
        public int Id
        {
            get;
            protected set;
        }

        public string FullName
        {
            get;
            protected set;
        }

        public BaseUser(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}
