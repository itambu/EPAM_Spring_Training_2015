using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLib.Core.Classes;
using MediaLib.Core.Interfaces;

namespace MediaLib.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityBuilder builder = new UnityBuilder(
                new List<IMediaItem>(),
                new List<IPlayList>());

            Unity unity = builder.Build();
        }
    }
}
