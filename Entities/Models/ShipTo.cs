using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{    
    public class ShipTo
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
