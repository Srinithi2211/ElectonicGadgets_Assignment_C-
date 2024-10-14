using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer;
using TechShop.entity;
using TechShop.exceptions;

namespace TechShop.collections
{


    public class ProductService
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            if (products.Any(p => p.ProductID == product.ProductID || p.ProductName == product.ProductName))
            {
                throw new InvalidDataException("Product with the same ID or name already exists.");
            }
            products.Add(product);
        }

        public void UpdateProduct(int productId, string newName, decimal newPrice)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                throw new InvalidDataException("Product not found.");
            }
            product.ProductName = newName;
            product.Price = newPrice;
        }

        public void RemoveProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                throw new InvalidDataException("Product not found.");
            }
            // Assume we need to check if there are existing orders for this product
            bool hasOrders = CheckForExistingOrders(productId);
            if (hasOrders)
            {
                throw new InvalidOperationException("Cannot remove a product with existing orders.");
            }
            products.Remove(product);
        }

        private bool CheckForExistingOrders(int productId)
        {
            // Simulate checking for existing orders (e.g., through an OrderService)
            return false; // Placeholder logic
        }
    }

}
