using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public interface ISentence : ICollection<ISentenceItem>
    {
        ICollection<ISentenceItem> Items { get; }
    }
}
