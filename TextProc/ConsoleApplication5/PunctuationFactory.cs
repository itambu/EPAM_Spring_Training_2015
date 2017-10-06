using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class PunctuationFactory : ISentenceItemFactory
    {
        IDictionary<string, ISentenceItem> cachedItems;
        
        public ISentenceItem Create(string chars)
        {
            return cachedItems.ContainsKey(chars) ? cachedItems[chars] : null;
        }

        public PunctuationFactory(SeparatorContainer separatorContainer)
        {
            this.cachedItems = new Dictionary<string, ISentenceItem>();
            foreach (var c in separatorContainer.All())
            {
                this.cachedItems.Add(c, new Punctuation(c));
            }
        }
    }
}
