using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salad.BL
{
    public class WeightedComponent : ISaladItem
    {
        public double Weight
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public WeightedComponent(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
