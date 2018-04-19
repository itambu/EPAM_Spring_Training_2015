using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class EventGenerator
    {
        private EventHandler<EventArgs> _click;

        public event EventHandler<EventArgs> Click 
        {
            add { _click += value; }
            remove { _click -= value; }
        }

        protected virtual void OnClick(object sender, EventArgs args)
        {
            var temp = _click;
            if (temp != null)
            {
                temp(sender, args);
            }
        }

        public void MyAction()
        {
            OnClick(this, new EventArgs());
        }

    }
}
