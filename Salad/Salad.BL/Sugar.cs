using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salad.BL
{
    public class Sugar : WeightedComponent, ICalorityable
    {
        public double CaloriesPerUnit
        {
            get;
            protected set;
        }

        public Sugar(string name, double weight, double calorityPerUnit)
            : base(name: name, weight: weight)
        {
            CaloriesPerUnit = calorityPerUnit;
        }
    }
}
