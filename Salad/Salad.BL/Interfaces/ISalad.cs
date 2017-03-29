using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.BL.Interfaces
{
    public interface ISalad
    {
        ICollection<ISaladItem> Items { get; }
        string Name { get; }

        double Weight { get; }
        double Sugar { get; }
    }
}
