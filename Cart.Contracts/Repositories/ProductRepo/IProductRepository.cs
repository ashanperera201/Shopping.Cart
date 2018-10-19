#region References
using Cart.Entities.DataTransferObjects;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Contracts.Repositories.ProductRepo
{
    public interface IProductRepository
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductDTO> GetProducts();
        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        ProductDTO GetProduct(ProductDTO product);
        /// <summary>
        /// Saves the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        ProductDTO SaveProduct(ProductDTO product);
        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        ProductDTO UpdateProduct(ProductDTO product);
        /// <summary>
        /// Determines whether [is product exists] [the specified product].
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   <c>true</c> if [is product exists] [the specified product]; otherwise, <c>false</c>.
        /// </returns>
        bool IsProductExists(ProductDTO product);
    }
}
#endregion
