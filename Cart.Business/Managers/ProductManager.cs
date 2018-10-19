#region References
using Cart.Common;
using Cart.Contracts.Common;
using Cart.Contracts.Managers;
using Cart.Contracts.Repositories.ProductRepo;
using Cart.Entities.Common;
using Cart.Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Business.Managers
{
    public class ProductManager : IProductManager
    {
        /// <summary>
        /// The product repository
        /// </summary>
        private readonly IProductRepository _productRepository;
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ICustomLogger _logger;
        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;
        /// <summary>
        /// The service response mapper
        /// </summary>
        private readonly IMapper<object, ServiceResponse> _serviceResponseMapper;
        /// <summary>
        /// The error messages handler
        /// </summary>
        private readonly IErrorMessagesHandler _errorMessagesHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductManager"/> class.
        /// </summary>
        /// <param name="productRepository">The product repository.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="serviceResponseErrorMapper">The service response error mapper.</param>
        /// <param name="serviceResponseMapper">The service response mapper.</param>
        /// <param name="errorMessagesHandler">The error messages handler.</param>
        public ProductManager(IProductRepository productRepository, ICustomLogger logger, IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper, IMapper<object, ServiceResponse> serviceResponseMapper, IErrorMessagesHandler errorMessagesHandler)
        {
            _productRepository = productRepository;
            _logger = logger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _serviceResponseMapper = serviceResponseMapper;
            _errorMessagesHandler = errorMessagesHandler;
        }

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ServiceResponse GetProduct(ProductDTO product)
        {
            try
            {
                var result = _productRepository.GetProduct(product);
                return _serviceResponseMapper.Map(result);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductManager>(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public ServiceResponse GetProducts()
        {
            try
            {
                var result = _productRepository.GetProducts();
                return _serviceResponseMapper.Map(result);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductManager>(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ServiceResponse SaveProduct(ProductDTO product)
        {
            try
            {
                product = StringExtensions.TrimStringProperties<ProductDTO>(product);
                //validation later
                var result = _productRepository.SaveProduct(product);
                return _serviceResponseMapper.Map(result);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductManager>(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public ServiceResponse UpdateProduct(ProductDTO product)
        {
            try
            {
                product = StringExtensions.TrimStringProperties<ProductDTO>(product);
                //validation latter
                var result = _productRepository.UpdateProduct(product);
                return _serviceResponseMapper.Map(result);
            }
            catch (Exception ex)
            {
                _logger.LogError<ProductManager>(ex.StackTrace);
                throw;
            }
        }
    }
}
#endregion