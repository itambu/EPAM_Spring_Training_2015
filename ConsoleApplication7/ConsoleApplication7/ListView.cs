using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class ListView
    {
        public void OnNewItem<T>(object sender, T item)
        {
            // -----------------------------------------
            Console.WriteLine(item);
        }
    }
}
