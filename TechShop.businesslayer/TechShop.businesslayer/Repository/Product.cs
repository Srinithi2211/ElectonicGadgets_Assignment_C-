using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.businesslayer.Services;

namespace TechShop.businesslayer.Repository
{
    public class ProductRepository : IProductService
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProduct(product.ProductID);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
            }
        }

        public Product GetProduct(int id)
        {
            return products.Find(p => p.ProductID == id);
        }
    }
}

