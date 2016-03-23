using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Sensors
{
    public interface ISensor
    {
        double Value { get; }
        int Id { get; }
        event EventHandler<double> Peek;

        void DoPeek();
    }
}
