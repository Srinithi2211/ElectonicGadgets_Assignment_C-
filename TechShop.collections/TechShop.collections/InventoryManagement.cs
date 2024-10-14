using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer;
using TechShop.entity;
using TechShop.ExceptionHandling;
using TechShop.exceptions;

namespace TechShop.collections
{
    public class InventoryService
    {
        private SortedList<int, Inventory> inventoryList = new SortedList<int, Inventory>();

        public void AddToInventory(Product product, int quantity)
        {
            if (inventoryList.ContainsKey(product.ProductID))
            {
                inventoryList[product.ProductID].QuantityInStock += quantity;
            }
            else
            {
                inventoryList.Add(product.ProductID, new Inventory(1, product, quantity));
            }
        }

        public Inventory GetInventory(int productId)
        {
            if (!inventoryList.ContainsKey(productId))
            {
                throw new InvalidDataException("Product not found in inventory.");
            }
            return inventoryList[productId];
        }

        public void RemoveFromInventory(int productId, int quantity)
        {
            var inventory = GetInventory(productId);
            if (inventory.QuantityInStock < quantity)
            {
                throw new InsufficientStockException("Not enough stock available.");
            }
            inventory.QuantityInStock -= quantity;
        }
    }

}
