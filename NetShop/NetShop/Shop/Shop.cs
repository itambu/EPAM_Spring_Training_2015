using NetShop.Category;
using NetShop.Element;
using NetShop.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Shop
{
    public class Shop
    {
        #region Category
        private ICategory _rootCategory;
        public void Add(ICategory category, ICategory parent)
        {
            if (parent != null)
            {
                parent.SubCategories.Add(category);
            }
            else
            {
                _rootCategory = category;
            }
        }

        public ICategory GetCategoryBy(Func<ICategory, bool> condition)
        {
            Queue<ICategory> queue= new Queue<ICategory>();
            if (_rootCategory!=null)
            {
                queue.Enqueue(_rootCategory);
                ICategory current = null;
                while (queue.Count > 0)
                {
                    current = queue.Dequeue();
                    if (condition(current))
                    {
                        return current;
                    }
                    else
                    {
                        foreach (var e in current.SubCategories)
                            queue.Enqueue(e);
                    }
                }
                
            }
            return null;
        }
        #endregion

        #region Elements
        private ICollection<IElement> _elements;

        protected IEnumerable<IElement> Elements 
        {
            get { return _elements; }
        }

        public void Add(IElement element)
        {
            _elements.Add(element);
        }

        public IElement GetElementBy(Func<IElement, bool> condition)
        {
            return Elements.FirstOrDefault(condition);
        }
 

        #endregion 

        #region Orders
        private ICollection<IOrder> _orders;
        public void Add(IOrder order)
        {
            _orders.Add(order);
            OnOrderChanged(this, order);
        }

        public event EventHandler<IOrder> OrderChanged;
        protected virtual void OnOrderChanged(object sender, IOrder order)
        {
            var temp = OrderChanged;
            if (temp != null)
            {
                temp(sender, order);
            }
        }
        #endregion

        public Shop(ICollection<IElement> elements, ICollection<IOrder> orders)
        {
            _elements = elements;
            _orders = orders;
        }

        public Shop()
        {
        }

    }
}
