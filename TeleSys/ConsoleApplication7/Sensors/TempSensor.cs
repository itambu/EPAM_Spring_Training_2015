using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Sensors
{
    public class TempSensor : BaseSensor, ISensor
    {
        public void DoPeek()
        {
            OnPeek(this, Value);
        }

        public double Value
        {
            get { return 200; }
        }
    }
}
