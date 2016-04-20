using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
            MyClass c = new MyClass() { Name = "ddddd", Items = new List<int>() { 1, 2, 3 } };
            using (var stream = new FileStream(@"d:\myxml.xml", FileMode.Create))
            {
                serializer.Serialize(stream, c);
            }
        }
    }
}
