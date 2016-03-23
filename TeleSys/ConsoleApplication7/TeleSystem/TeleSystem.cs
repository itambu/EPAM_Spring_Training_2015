using ConsoleApplication7.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.TeleSystem
{
    public class TeleSystem
    {
        
        public ICollection<SensorData> Items { get; protected set; }
        public Func<ISensor, string> GetSensorType { get; set; }

        public TeleSystem( ICollection<SensorData> source, Func<ISensor, string> sensorType )
        {
            Items = source;
            GetSensorType = sensorType;
        }

        public void OnSensorPeek(object sender, double arg)
        {
            ISensor sensor = sender as ISensor;
            if (sensor!=null)
            {
                Items.Add(new SensorData()
                {
                    SensorId = sensor.Id,
                    Time = DateTime.Now,
                    value = arg,
                    SensorType = GetSensorType(sensor)
                }
                );
            }
        }
    }
}
