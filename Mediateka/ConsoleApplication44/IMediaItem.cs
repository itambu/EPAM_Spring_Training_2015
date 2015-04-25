using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public interface IMediaItem
    {
        DateTime CreationDate { get; }
        Rating Rating { get; }
        string Name { get; }
    }
}
