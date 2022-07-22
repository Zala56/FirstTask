using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class Customer
    {
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
