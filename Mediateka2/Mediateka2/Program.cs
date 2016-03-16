using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka2
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture p = new Picture(@"d:\mylocation", "BonneyM", 
                new PictureProperty() 
                { 
                    Size = new PictureSize() 
                    { 
                        Width = 100, Height = 100 
                    } 
                });

            Track t = new Track(@"d:\mylocation", "Rumba", new TimeSpan(0, 3, 40));

            //IMediaElement i = p as IMediaElement;
            //IHasLocation k = i as IHasLocation;

            Mediateka m = new Mediateka(new List<IMediaElement>() { p, t });

            m.ShowAll();

            foreach (var item in m.Items)
            {
                Console.WriteLine("{0}", item.Name);
                item.Play();

                //if (item is Picture)
                //{
                //    (item as Picture).Play();
                //}
                //else if (item is Track)
                //{
                //}
                //else if (item is Album)
                //{
                //}
            }
            
            //LocalizedItem p1 = p;
            //Item p2 = p;

            //object p3 = p;

            //Picture p4 = (Picture)p3;

            //Album p5 = (Album)p3;

            //Album p6 = p3 as Album;

            //if (p3 is Album)
            //{
            //    Album p7 = (Album)p3;
            //}
        }
    }
}
