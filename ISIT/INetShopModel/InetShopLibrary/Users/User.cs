using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.Users
{
    public class User : BaseUser, IUser
    {
        public Address Address
        {
            get;
            protected set;
        }

        public User(int id, string fullName, Address address) : base(id, fullName)
        {
            this.Address = address;
        }
    }
}
