using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.collections
{
    public class OrderDetailService
    {
        private InventoryService inventoryService = new InventoryService();

        public void ValidateOrderDetail(OrderDetail orderDetail)
        {
            var inventory = inventoryService.GetInventory(orderDetail.Product.ProductID);
            if (inventory.QuantityInStock < orderDetail.Quantity)
            {
                throw new InsufficientStockException("Not enough stock for the product.");
            }
        }
    }

}
