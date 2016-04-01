using NetShop.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Category
{
    public interface ICategory
    {
        int Id { get; }
        string Name { get; }
        ICollection<ICategory> SubCategories { get; }
    }
}
