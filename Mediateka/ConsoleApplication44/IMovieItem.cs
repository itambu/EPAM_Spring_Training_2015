using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public interface IMovieItem : IMediaItem
    {
        TimeSpan Duration { get; }
    }
}
