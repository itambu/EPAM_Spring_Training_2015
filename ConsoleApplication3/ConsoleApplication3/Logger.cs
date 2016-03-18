using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Logger
    {
        public LogAction Action { get; set; }

        public void Log(string source)
        {
            if (Action != null)
            {
                Action(source);
            }
        }
    }
}
