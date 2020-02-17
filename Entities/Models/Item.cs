using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
