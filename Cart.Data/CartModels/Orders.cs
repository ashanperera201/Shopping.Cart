using System;
using System.Collections.Generic;

namespace Cart.Data.CartModels
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
