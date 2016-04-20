using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication9
{
    public class MyClass
    {
        [XmlElement(ElementName="FullName")]
        public string Name { get; set; }
        public List<int> Items { get; set; }
    }
}
