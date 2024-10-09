using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.businesslayer.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProduct(int id);
    }
}
