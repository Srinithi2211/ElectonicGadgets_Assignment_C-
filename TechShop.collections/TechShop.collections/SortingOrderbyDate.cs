using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.businesslayer;
using TechShop.ExceptionHandling;
using TechShop.exceptions;

namespace TechShop.collections
{
    public class OrderSortingService
    {
        public List<Order> SortOrdersByDate(List<Order> orders, bool ascending = true)
        {
            return ascending
                ? orders.OrderBy(o => o.OrderDate).ToList()
                : orders.OrderByDescending(o => o.OrderDate).ToList();
        }
    }

}
