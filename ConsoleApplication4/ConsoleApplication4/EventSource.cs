using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class EventSource : INotifyPropertyChanged
    {
        private EventHandler<EventArgs> _myEvent;
        public event EventHandler<EventArgs> MyEvent
        {
            add { _myEvent += value; }
            remove { _myEvent -= value; }
        }

        public void MyProcess()
        {
            OnMyEvent(this, null);
        }

        protected virtual void OnMyEvent(object sender, EventArgs e)
        {
            EventHandler<EventArgs> temp = null;
            Interlocked.Exchange(ref temp, _myEvent);
            if (temp != null)
            {
                temp(this, null);
            }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnNotifyPropertyChanged();
                }
            }
        }

        public void ActionOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
