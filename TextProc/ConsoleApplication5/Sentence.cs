using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Sentence
    {
        public ICollection<ISentenceItem> Items { get; set; }

        public Sentence()
        {
            Items = new List<ISentenceItem>();
        }

        public Sentence(IEnumerable<ISentenceItem> source) : this()
        {
            foreach(var c in source)
            {
                Items.Add(c);
            }
        }
    }
}
