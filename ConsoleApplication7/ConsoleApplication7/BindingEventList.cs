using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class BindingEventList<T> : List<T>
    {
        public event EventHandler<T> AddEvent;

        protected virtual void OnAddEvent(object sender, T e)
        {
            var temp = AddEvent;
            if (temp!=null)
            {
                temp(sender, e);
            }
        }

        public new void Add(T item)
        {
            base.Add(item);
            OnAddEvent(this, item);
        }
    }
}
