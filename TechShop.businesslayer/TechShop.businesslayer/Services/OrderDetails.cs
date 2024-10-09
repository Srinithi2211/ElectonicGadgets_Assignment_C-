using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.businesslayer.Services
{
    public interface IOrderDetailService
    {
        void AddOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetail(int id);
        void UpdateQuantity(int orderDetailId, int newQuantity);
       
    }
}
