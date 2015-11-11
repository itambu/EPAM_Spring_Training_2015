using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InetShopLibrary.Users
{
    public class Manager : BaseUser, IManager
    {
        public Manager(int id, string fullName)
            : base(id, fullName)
        {
        }
    }
}
