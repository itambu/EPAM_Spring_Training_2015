using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Sensors
{
    public abstract class BaseSensor
    {
        public int Id { get; set; }

        protected EventHandler<double> _peekAction;
        protected virtual void OnPeek(object sender, double arg)
        {
            var temp = _peekAction;
            if (temp != null)
            {
                temp(sender, arg);
            }
        }

        public event EventHandler<double> Peek
        {
            add { _peekAction += value; }
            remove { _peekAction -= value; }
        }
    }
}
