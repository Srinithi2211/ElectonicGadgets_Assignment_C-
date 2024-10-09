using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.businesslayer.Services
{
    public interface IInventoryService
    {
        void AddInventory(Inventory inventory);
        Inventory GetInventory(int id);
        void AddToInventory(int productId, int quantity);
        void RemoveFromInventory(int productId, int quantity);
        bool IsProductAvailable(int productId, int quantityToCheck);
    }
}
