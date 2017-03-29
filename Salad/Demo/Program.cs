using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.BL.Interfaces;
using Salad.BL.Classes;
using Salad.BL;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            Tomato t = new Tomato("Помидор", 122, 80);

            GeneralSalad salad = new GeneralSalad("Greek", new List<ISaladItem>());
            //GeneralSalad s1 = new GeneralSalad("GGGG", new LinkedList<ISaladItem>());
            salad.Items.Add(t);
        }
    }
}
