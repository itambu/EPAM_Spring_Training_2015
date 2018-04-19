using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public delegate bool SearchCriteria(int item);
        
        static void Main()
        {
            List<int> source = new List<int>(){1,2,3,4};
            
            int item = SearchFirstElementWithDelegate(source, FirstEven);

        }

        static int SearchFirstElement(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                if (item % 2 == 0)
                {
                    return item;
                }
            }
            throw new ArgumentOutOfRangeException("");
        }

        static int SearchFirstElementWithDelegate(IEnumerable<int> collection, SearchCriteria criteria )
        {
            foreach (var item in collection)
            {
                if (criteria!=null && criteria(item) )
                {
                    return item;
                }
            }
            throw new ArgumentOutOfRangeException("");
        }

        static bool FirstEven(int item)
        {
            return item % 2 == 0;
        }
    }
}
