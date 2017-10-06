using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Alias { get; set; }
        Contact Contact { get; set; }
    }
}
