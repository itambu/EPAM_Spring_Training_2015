using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reference
{
    public class Concordance<Key, Reference> 
    {
        private IDictionary<Key, ConcordanceItem<Key, Reference>> _concordance;

        public Concordance( IDictionary<Key, ConcordanceItem<Key, Reference>> container)
        {
            _concordance = container;
        }

        public void Build(IEnumerable<KeyValuePair<Key, Reference>> source)
        {
            foreach(var group in source.GroupBy(x => x.Key, x => x.Value))
            {
                _concordance.Add(group.Key, new ConcordanceItem<Key, Reference>(group.Key, group.Distinct().OrderBy(x => x)));
            }
        }
    }
}
