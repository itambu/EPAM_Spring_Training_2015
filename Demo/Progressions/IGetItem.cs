using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public interface IGetItem
    {
        double this[int index] { get; }
    }
}
