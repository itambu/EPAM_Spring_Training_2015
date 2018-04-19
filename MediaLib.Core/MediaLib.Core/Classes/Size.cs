using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib.Core.Classes
{
    public struct Size
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
