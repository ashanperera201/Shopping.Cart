#region References
using Cart.Contracts.Repositories.ProductRepo;
using Cart.Data.CartModels;
using Cart.Entities.DataTransferObjects;
using System.Collections.Generic;
#endregion


#region Namespace
namespace Cart.Data.Repositories
{
    public class ProductRepository : GenericDataRepository<Products, ProductDTO>, IProductRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="shoppingContext"></param>
        public ProductRepository(ShoppingContext shoppingContext) : base(shoppingContext)
        { }
        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ProductDTO GetProduct(ProductDTO product)
        {
            return base.SingleOrDefault(p => p.Id == product.Id);
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductDTO> GetProducts()
        {
            return base.GetAll();
        }

        /// <summary>
        /// Determines whether [is product exists] [the specified product].
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns>
        /// <c>true</c> if [is product exists] [the specified product]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsProductExists(ProductDTO product)
        {
            return base.Any(p => p.Id == product.Id);
        }

        /// <summary>
        /// Saves the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ProductDTO SaveProduct(ProductDTO product)
        {
            return base.InsertModel(product);
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ProductDTO UpdateProduct(ProductDTO product)
        {
            return base.UpdateModel(product);
        }
    }
}
#endregion