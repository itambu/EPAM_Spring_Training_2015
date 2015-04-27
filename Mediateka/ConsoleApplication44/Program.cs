using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediateka mediateka = new Mediateka();

            mediateka.Add(new Clip() { 
                Name = "Ace of base", 
                Duration = new TimeSpan(0, 2, 30), 
                Rating = Rating.Average, 
                CreationDate = new DateTime(2010, 10, 3) }
                );
            mediateka.Add(new Photo() { 
                Name = "Mountain", 
                Rating = Rating.Low, 
                CreationDate = new DateTime(2005, 5, 5) }
                );
            #region add serial
            SerialBuilder serialBuilder = new SerialBuilder()
            {
                Name = "Game of Thrones",
                CreationDate = new DateTime(2009, 4, 4),
                Rating = Rating.High,
            };

            Season season = new Season() { Name = "dsdsd", CreationDate = new DateTime(2009, 6, 6), Rating = Rating.High };
            season.Add(new Movie() { Name = "Origin", Duration = new TimeSpan(0, 40, 0), Rating = Rating.High, CreationDate = new DateTime(2009, 6, 6) });

            serialBuilder.Seasons.Add(season);
            mediateka.Add(serialBuilder.Construct());
            #endregion

            mediateka.SortByCreationDate();

            foreach (var i in mediateka)
            {
                Console.WriteLine("{0}, {1}", i.Name, i.CreationDate);
            }

            //object obj = new object();
            //obj = new object();
            //object obj1 = new object();

            //string sss = "System.Object";
            //Console.WriteLine("{0} {1}", obj.GetHashCode(), obj1.GetHashCode());

            //Dictionary<Movie, string> dic = new Dictionary<Movie, string>();
            
        }
    }
}
