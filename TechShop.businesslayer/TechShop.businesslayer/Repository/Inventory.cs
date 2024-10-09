using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer.Services;
using TechShop.entity;

namespace TechShop.businesslayer.Repository
{
    public class InventoryRepository : IInventoryService
    {
        private List<Inventory> inventories = new List<Inventory>();

        public void AddInventory(Inventory inventory)
        {
            inventories.Add(inventory);
        }

        public Inventory GetInventory(int id)
        {
            return inventories.Find(inv => inv.InventoryID == id);
        }

        public void AddToInventory(int productId, int quantity)
        {
            var inventory = inventories.Find(inv => inv.Product.ProductID == productId);
            if (inventory != null)
            {
                inventory.QuantityInStock += quantity;
                inventory.LastStockUpdate = System.DateTime.Now;
            }
        }

        public void RemoveFromInventory(int productId, int quantity)
        {
            var inventory = inventories.Find(inv => inv.Product.ProductID == productId);
            if (inventory != null && inventory.QuantityInStock >= quantity)
            {
                inventory.QuantityInStock -= quantity;
                inventory.LastStockUpdate = System.DateTime.Now;
            }
        }

        public bool IsProductAvailable(int productId, int quantityToCheck)
        {
            var inventory = inventories.Find(inv => inv.Product.ProductID == productId);
            return inventory != null && inventory.QuantityInStock >= quantityToCheck;
        }
    }
}
