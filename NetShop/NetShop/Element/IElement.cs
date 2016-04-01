using NetShop.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Element
{
    public interface IElement
    {
        int Id { get; }
        string Name { get; }
        ICategory Category { get; }

    }
}
