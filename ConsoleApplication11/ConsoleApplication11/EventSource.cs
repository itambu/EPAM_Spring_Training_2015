using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public class EventSource
    {
        private EventHandler<string> _myEvent;
        public event EventHandler<string> MyEvent 
        {
            add { _myEvent += value; }
            remove { _myEvent -= value; }
        }

        public void MyAction()
        {
            OnMyEvent(this, "");
        }

        protected virtual void OnMyEvent(object sender, string message)
        {
            var temp = _myEvent;// Interlocked
            if (temp!=null)
            {
                temp(sender, message);
            }
        }
    }
}
