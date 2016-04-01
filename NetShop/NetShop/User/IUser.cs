using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.User
{
    public interface IUser
    {
        int Id { get; }
        string FullName { get; }
    }
}
