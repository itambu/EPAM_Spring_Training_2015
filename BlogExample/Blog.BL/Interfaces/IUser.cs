using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BL.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Alias { get; set; }
        Blog.Entities.Contact Contact { get; set; }
    }
}
