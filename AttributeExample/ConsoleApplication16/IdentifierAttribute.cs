using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    [AttributeUsage(AttributeTargets.Class, Inherited=true)]
    public class IdentifierAttribute : Attribute
    {
        public string PropertyName { get; set; }
    }
}
