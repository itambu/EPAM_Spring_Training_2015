using Mediateka3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mediateka3.Interfaces
{
    public interface IMediaItem : INameable
    {
        Rate Rate { get; }
        Int64 PhysicalSize { get; }
        StreamReader MediaStream { get; }
    }
}
