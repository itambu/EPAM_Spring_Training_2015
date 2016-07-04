using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    public class ConcordanceItem<TKey, Reference> : IConcordanceItem<TKey, Reference>
    {
        private TKey _key;
        private IEnumerable<Reference> _references;
        public TKey Key
        {
            get { return _key; }
        }

        public IEnumerable<Reference> References
        {
            get { return _references; }
        }

        public ConcordanceItem(TKey sourceKey, IEnumerable<Reference> sourceReferences)
        {
            _key = sourceKey;
            _references = sourceReferences;
        }
    }
}
