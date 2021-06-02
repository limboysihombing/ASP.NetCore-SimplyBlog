using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Domain.Entities
{
    public partial class Order
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderStatus { get; set; }
    }
}
