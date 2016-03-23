using ConsoleApplication7.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.TeleSystem
{
    public class SensorData
    {
        public int SensorId { get; set; }
        public double value { get; set; }
        public DateTime Time { get; set; }
        public string SensorType { get; set; }
    }
}
