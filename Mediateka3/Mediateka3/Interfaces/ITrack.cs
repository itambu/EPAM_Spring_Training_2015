using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka3.Interfaces
{
   public  interface ITrack : IMediaItem
    {
       TimeSpan Duration { get; }
       string Genre { get; }
    }
}
