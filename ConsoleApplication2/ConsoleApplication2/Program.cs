using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet[] sweets = new Sweet[]
            {
                new RedSweet(10),
                new BlueSweet(10)
            };

            foreach (IExecuteAction sweet in sweets)
            {
                sweet.Action();
            }


            BlueSweet bs = new BlueSweet(10);
            BigBlueSweet bbs = new BigBlueSweet(10);

            IExecuteAction i1 = bbs;
            i1.Action();

            ActionItemList list = new ActionItemList();
        }

        public static void Eat(Sweet sweet)
        {
            var p = sweet.Calority;
            BlueSweet bs2 = sweet as BlueSweet;
            if (bs2 != null)
            {
                
            }
        }
    }
}
