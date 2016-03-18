using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Action = new LogAction(ConsoleLog.MyConsoleLog)
                + new LogAction(ConsoleLog.MyFileLog);

            TestClass tc = new TestClass();

            logger.Action += tc.LogToPort;

            logger.Log("Hello!");

            logger.Action -= ConsoleLog.MyConsoleLog;
            logger.Action -= ConsoleLog.MyConsoleLog;
            logger.Log("Bye!");
            //----------------------------------------------------
            //LogAction lg = new LogAction(ConsoleLog.MyConsoleLog)
            //    + new LogAction(ConsoleLog.MyFileLog);
            //LogAction lg1 = lg + ConsoleLog.MyFileLog;

            //----------------------------------------------------

            foreach (var c in logger.Action.GetInvocationList())
            {
                if (c.Method == typeof(ConsoleLog).GetMethod("MyConsoleLog"))
                {

                }
            }
        }
    }
}
