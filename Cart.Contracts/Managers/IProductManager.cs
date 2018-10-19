#region References
using Cart.Entities.Common;
using Cart.Entities.DataTransferObjects;
#endregion

#region Namespace
namespace Cart.Contracts.Managers
{
    public interface IProductManager
    {
        ServiceResponse GetProducts();
        ServiceResponse GetProduct(ProductDTO product);
        ServiceResponse SaveProduct(ProductDTO product);
        ServiceResponse UpdateProduct(ProductDTO product);
    }
}
#endregion