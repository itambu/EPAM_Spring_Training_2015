using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity e = new Entity() { Id = 5 };
            object pk = IdentifierBuilder.GetIdentifier(e);

            //---------------------------------
            Months m = Months.January | Months.February;

            ICollection<Entity> list = new List<Entity>()
            {
                new Entity(){Id= 1},
                new Entity(){ Id = 2}
            };

            XmlSerializer serializer = new XmlSerializer(list.GetType());
            using (StreamWriter writer = new StreamWriter(new FileStream(@"d:\test.xml", FileMode.Create)))
            {
                serializer.Serialize(writer, list);
            }

        }
    }
}
