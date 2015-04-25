using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class Photo : MediaItem, IStaticItem
    {
        public string Tag { get; set; }
    }
}
