#region References
using System.ComponentModel.DataAnnotations;
#endregion

#region Namespace
namespace Cart.Entities.DataTransferObjects
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderDTO Order { get; set; }
        public virtual ProductDTO Product { get; set; }
    }
}
#endregion