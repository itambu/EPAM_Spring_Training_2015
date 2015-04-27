using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    public class SerialBuilder
    {
        public DateTime CreationDate { get; set; }
        public Rating Rating { get; set; }
        public string Name { get; set; }
        public ICollection<Season> Seasons{get;set;}

        private Serial serial = new Serial();

        public SerialBuilder()
        {
            Seasons = new List<Season>();
        }

        public Serial Construct()
        {
            ConstructSerial();
            ConstructSeasons();
            return serial;
        }

        protected void ConstructSerial()
        {
            serial.CreationDate = this.CreationDate;
            serial.Rating = this.Rating;
            serial.Name = this.Name;
        }

        protected void ConstructSeasons()
        {
            serial.Clear();
            foreach (var s in this.Seasons)
            {
                serial.Add(s);
            }
        }
    }
}
