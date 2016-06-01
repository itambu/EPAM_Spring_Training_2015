using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication6.Models;

namespace MvcApplication6.Repositories
{
    public class ProductRepository
    {
        private static List<Product> ProductList = new List<Product>()
            {
                new Product(){Id=1, Description="dgsjgsj", Appeared=DateTime.Now}
            };

        public Product FirstOrDefault(Func<Product, bool> condition)
        {
            return ProductList.FirstOrDefault(condition);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductList;
        }

        public void Update(Product newProduct)
        {
            var oldProduct = ProductList.FirstOrDefault(x => x.Id == newProduct.Id);
            if (oldProduct != null)
            {
                oldProduct.Appeared = newProduct.Appeared;
                oldProduct.Description = newProduct.Description;
            }
            else
            {
                throw new InvalidOperationException("Product not founded");
            }
        }

        public void Insert(Product newProduct)
        {
            ProductList.Add(newProduct);
        }

    }
}