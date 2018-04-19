using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication10
{
    public class WildAttribute : Attribute
    {
        public string Name { get; private set; }
        public int Number { get; set; }

        public WildAttribute(string name)
        {
            Name = name;
        }
    }
}
