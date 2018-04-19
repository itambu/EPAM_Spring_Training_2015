using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Interfaces
{
    public interface IPlayList : ICollection<IMediaItem>, IMediaItem
    {
        DateTime Created { get; }
    }
}
