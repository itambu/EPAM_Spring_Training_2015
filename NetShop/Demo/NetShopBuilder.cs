using NetShop.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CustomShopBuilder
    {
        private Shop _shop;
        public CustomShopBuilder(Shop shop)
        {
            _shop = shop;
        }

        public void Build()
        {
            AddCategories();
        }
        
        protected void AddCategories()
        {
            //TODO 
        }
    }
}
