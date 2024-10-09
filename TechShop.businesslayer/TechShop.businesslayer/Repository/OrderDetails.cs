using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer.Services;
using TechShop.entity;

namespace TechShop.businesslayer.Repository
{
    public class OrderDetailRepository : IOrderDetailService
    {
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDetails.Add(orderDetail);
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return orderDetails.Find(od => od.OrderDetailID == id);
        }

        public void UpdateQuantity(int orderDetailId, int newQuantity)
        {
            var orderDetail = GetOrderDetail(orderDetailId);
            if (orderDetail != null)
            {
                orderDetail.Quantity = newQuantity;
            }
        }

        
    }
}

