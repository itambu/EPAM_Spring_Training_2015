using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka3.Interfaces
{
    public interface IPlayList : INameable
    {
        TimeSpan Duration { get; }
        ICollection<IMediaItem> Items { get; }
    }
}
