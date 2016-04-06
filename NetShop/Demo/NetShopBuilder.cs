using NetShop.Category;
using NetShop.Element;
using NetShop.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public partial class CustomShopBuilder
    {
        private Shop _shop;
        public CustomShopBuilder(Shop shop)
        {
            _shop = shop;
        }

        public void Build()
        {
            AddCategories();
            AddElements();
        }
        
        protected void AddCategories()
        {
            ICategory root = new Category( new List<ICategory>() ){Id = 0, Name= "All"};
            _shop.Add(root, null);
            _shop.Add(new Category(new List<ICategory>()) { Id = 1, Name = "Вилы" }, root);
            _shop.Add(new Category(new List<ICategory>()) { Id = 2, Name = "Грабли" }, root);
            _shop.Add(new Category(new List<ICategory>()) { Id = 3, Name = "Фуфайки" }, root);
        }

        protected void AddElements()
        {
            _shop.Add(new Element() 
            { 
                Id = 0, 
                Name = "Вилы трехзубчатые", 
                Category = _shop.GetCategoryBy(x => x.Name == "Вилы") 
            });

            _shop.Add(new Element()
            {
                Id = 0,
                Name = "Грабли замечательные",
                Category = _shop.GetCategoryBy(x => x.Name == "Грабли")
            });
        }


    }
}
