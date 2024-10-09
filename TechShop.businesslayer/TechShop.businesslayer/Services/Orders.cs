using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.businesslayer.Services
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        Order GetOrder(int id);
        List<OrderDetail> GetOrderDetails(int orderId);
       
    }
}
