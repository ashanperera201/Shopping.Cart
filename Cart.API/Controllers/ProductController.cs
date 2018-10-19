#region References
using System;
using System.Collections.Generic;
using Cart.Contracts.Common;
using Cart.Contracts.Managers;
using Cart.Entities.Common;
using Cart.Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
#endregion


#region Namespace
namespace Cart.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;
        private readonly ICustomLogger _logger;
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;
        private readonly IErrorMessagesHandler _errorMessagesHandler;

        public ProductController(IProductManager productManager, ICustomLogger customLogger, IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper, IErrorMessagesHandler errorMessagesHandler)
        {
            _productManager = productManager;
            _logger = customLogger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _errorMessagesHandler = errorMessagesHandler;
        }

        [HttpGet("products")]
        public ServiceResponse GetProducts()
        {
            try
            {
                return _productManager.GetProducts();
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductController>(ex.StackTrace);
                throw;
            }
        }

        [HttpPost("product")]
        public ServiceResponse GetProduct(ProductDTO product)
        {
            try
            {
                return _productManager.GetProduct(product);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductController>(ex.StackTrace);
                throw;
            }
        }

        [HttpPost("insert-product")]
        public ServiceResponse SaveProduct(ProductDTO product)
        {
            try
            {
                return _productManager.SaveProduct(product);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductController>(ex.StackTrace);
                throw;
            }
        }

        [HttpPost("update-product")]
        public ServiceResponse UpdateProduct(ProductDTO product)
        {
            try
            {
                return _productManager.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductController>(ex.StackTrace);
                throw;
            }
        }
    }
}
#endregion
