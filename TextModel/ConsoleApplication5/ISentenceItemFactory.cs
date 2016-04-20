using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public interface ISentenceItemFactory
    {
        ISentenceItem Create(string chars);
    }
}
