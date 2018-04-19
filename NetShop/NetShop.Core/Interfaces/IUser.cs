using System;
using System.Collections.Generic;
using System.Text;

namespace NetShop.Core.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
