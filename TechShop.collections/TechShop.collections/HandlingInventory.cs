using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.collections
{
    public class InventoryUpdateService
    {
        private InventoryService inventoryService = new InventoryService();

        public void UpdateInventory(Order order)
        {
            foreach (var detail in order.OrderDetails)
            {
                inventoryService.RemoveFromInventory(detail.Product.ProductID, detail.Quantity);
            }
        }
    }

}
