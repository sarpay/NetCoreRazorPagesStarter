using System;
using System.Collections.Generic;

namespace RazorPagesVizyoneks2.Models
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
