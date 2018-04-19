using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Interfaces
{
    public interface IMediaItem
    {
        Guid Id { get; }
        string Name { get; set; }
        Enums.Rating Rating { get; set; }
    }
}
