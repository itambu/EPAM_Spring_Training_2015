using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Category
{
    public class Category : ICategory
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        ICollection<ICategory> _subCategories;
        public ICollection<ICategory> SubCategories
        {
            get { return _subCategories; }
        }

        public Category(ICollection<ICategory> subCategories)
        {
            _subCategories = subCategories;
        }
    }
}
