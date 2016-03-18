using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Sender
    {
        private EventHandler<string> _myEvent;

        public event EventHandler<string> MyEvent
        {
            add { _myEvent += value; }
            remove { _myEvent -= value; }
        }

        public void EventGenerator()
        {
            OnMyEvent(this, null);
        }



        protected virtual void OnMyEvent(object sender, string args)
        {
            var temp = _myEvent;
            if (temp != null)
            {
                temp(sender, args);
            }
        }
    }
}
