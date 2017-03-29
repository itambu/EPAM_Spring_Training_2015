using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.BL.Classes
{
    public class GeneralSalad : ISalad
    {
        public double Weight
        {
            get 
            {
                if (Items != null)
                {
                    //double s = 0;
                    //foreach (var i in Items)
                    //{
                    //    s += i.Weight;
                    //}
                    //return s;
                    return Items.Sum(x => x.Weight);
                }
                else
                {
                    throw new InvalidOperationException("Container in Salad cannot be null");
                }
            }
        }

        public string Name
        {
            get;
            protected set;
        }

        public ICollection<ISaladItem> Items
        {
            get;
            private set;
        }

        public double Sugar
        {
            get { throw new NotImplementedException(); }
        }

        public GeneralSalad(string name, ICollection<ISaladItem> items)
        {
            Name = name;
            Items = items;
        }
    }
}
