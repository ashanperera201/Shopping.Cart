#region References
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#endregion

#region Namespace
namespace Cart.Entities.DataTransferObjects
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [MinLength(4)]
        public string OrderNumber { get; set; }
        public ICollection<OrderItemDTO> OrderItem { get; set; }
    }
}
#endregion
