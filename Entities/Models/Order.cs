using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<ShipTo> ShipTos { get; set; }
        public List<OrderItem> Items { get; set; }
        public int Shipping { get; set; }
        public int Tax { get; set; }
        public int Gross { get; set; }
        public int Total { get; set; }
    }
}
