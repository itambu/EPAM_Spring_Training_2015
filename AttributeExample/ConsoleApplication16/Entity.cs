using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication16
{
    [Identifier(PropertyName="Id")]
    public class Entity
    {
        [XmlAttribute(AttributeName="Identifier")]
        public int Id { get; set; }
    }
}
