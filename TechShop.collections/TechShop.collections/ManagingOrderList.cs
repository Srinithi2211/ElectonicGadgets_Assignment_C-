using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer;
using TechShop.entity;
using TechShop.exceptions;
using TechShop.ExceptionHandling;

namespace TechShop.collections
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
            UpdateInventory(order);
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            var order = orders.FirstOrDefault(o => o.OrderID == orderId);
            if (order == null)
            {
                throw new InvalidDataException("Order not found.");
            }
            order.Status = status;
            // Update payment or other information if needed
        }

        public void RemoveOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderID == orderId);
            if (order == null)
            {
                throw new InvalidDataException("Order not found.");
            }
            orders.Remove(order);
        }

        private void UpdateInventory(Order order)
        {
            // Logic to decrement inventory based on the order details
        }
    }

}
