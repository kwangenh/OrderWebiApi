using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IOrderItemRepository
    {
        public List<OrderItem> GetOrderItems();
        public OrderItem GetOrderItem(int orderItemId);
        public OrderItem CreateOrderItem(OrderItem thisOrderItem);
        public OrderItem DeleteOrderItem(int orderItemId);
        public OrderItem EditOrderItem(OrderItem thisOrderItem);
    }
}
