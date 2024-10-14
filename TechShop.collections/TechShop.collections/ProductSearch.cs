using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.collections
{
    public class ProductSearchService
    {
        private List<Product> products = new List<Product>();

        public List<Product> SearchProductsByName(string name)
        {
            return products.Where(p => p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SearchProductsByCategory(string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }
    }

}
