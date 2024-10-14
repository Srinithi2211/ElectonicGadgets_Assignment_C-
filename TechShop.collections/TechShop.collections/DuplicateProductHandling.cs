using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.collections
{
    public void AddProductWithCheck(Product product)
    {
        if (products.Any(p => p.ProductName == product.ProductName))
        {
            throw new InvalidDataException("Duplicate product found.");
        }
        products.Add(product);
    }

}
