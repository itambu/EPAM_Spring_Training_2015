using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reference;

namespace ConcordanceTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> source = new List<KeyValuePair<string, int>>();
            
            Random random = new Random();
            for(int i = 0; i < 10000000; i++)
            {
                
                source.Add( 
                    new KeyValuePair<string, int>((i % 1000).ToString(), 
                        random.Next()));
            }

            
            {
                var c = new Concordance<string, int>( 
                new SortedDictionary<string, ConcordanceItem<string, int>>() 
                );

                c.Build(source.AsParallel());
            }
        }
    }
}
