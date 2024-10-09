using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer.Services;
using TechShop.entity;

namespace TechShop.businesslayer.Repository
{
    public class OrderRepository : IOrderService
    {
        private List<Order> orders = new List<Order>();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public Order GetOrder(int id)
        {
            return orders.Find(o => o.OrderID == id);
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return orderDetails.Where(od => od.Order.OrderID == orderId).ToList();
        }

        
    }
}
