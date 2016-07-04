using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    public interface IConcordanceItem<TKey, Reference>
    {
        TKey Key { get; }
        IEnumerable<Reference> References { get; }
    }
}
