using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediateka2
{
    public class Mediateka
    {
        public List<IMediaElement> Items { get; protected set; }

        public Mediateka(List<IMediaElement> items)
        {
            this.Items = items;
        }

        public void ShowAll()
        {
            foreach (var item in this.Items)
            {
                Console.WriteLine("{0}", item.Name);
            }
        }

        public void PlayAll()
        {
            foreach (var item in this.Items)
            {
                IHasLocation temp = item as IHasLocation;
                if (temp != null)
                {
                    ChangeDataSource(temp.Location);
                    item.Play();
                }
            }
        }

        protected void ChangeDataSource(string p)
        {
            throw new NotImplementedException();
        }
    }
}
