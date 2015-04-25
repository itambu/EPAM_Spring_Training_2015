using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public interface IStaticItem : IMediaItem
    {
        string Tag { get; }
    }
}
