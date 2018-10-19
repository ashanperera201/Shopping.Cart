using System;
using System.Collections.Generic;

namespace Cart.Data.CartModels
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? OrderId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
