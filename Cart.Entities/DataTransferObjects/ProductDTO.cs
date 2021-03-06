﻿#region References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Entities.DataTransferObjects
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string ArtDescription { get; set; }
        public string ArtDating { get; set; }
        public string ArtId { get; set; }
        public string Artist { get; set; }
        public DateTime ArtistBirthDate { get; set; }
        public DateTime ArtistDeathDate { get; set; }
        public string ArtistNationality { get; set; }

        public ICollection<OrderItemDTO> OrderItem { get; set; }
    }
}
#endregion
