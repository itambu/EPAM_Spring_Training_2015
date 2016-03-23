using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication7.TeleSystem;
using ConsoleApplication7.Sensors;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApplication7.TeleSystem.TeleSystem ts = new ConsoleApplication7.TeleSystem.TeleSystem(
                new List<SensorData>(),
                x =>
                {
                    if (x.GetType() == typeof(TempSensor))
                    {
                        return "Temp";
                    }

                    if (x.GetType() == typeof(PressureSensor))
                    {
                        return "Press";
                    }
                    return null;
                });

            var s1 = new TempSensor() { Id = 1 };
            var s2 = new PressureSensor() { Id = 2 };

            // ---------------------------------------------

            s1.Peek += ts.OnSensorPeek;
            s2.Peek += ts.OnSensorPeek;

            s1.DoPeek();
            s2.DoPeek();


        }
    }
}
