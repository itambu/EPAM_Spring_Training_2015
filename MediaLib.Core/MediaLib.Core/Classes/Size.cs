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
        object p;
        public Size(int width, int height) 
        {
            p = null;
            Width = width;
            Height = height;
        }
    }
}
