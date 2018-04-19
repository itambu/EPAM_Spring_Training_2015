using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Base.Classes
{
    public class ShopUser : NetShop.Core.Interfaces.IUser
    {
        public ShopUser(int Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public int Id
        {
            get;
            private set;
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }
    }
}
