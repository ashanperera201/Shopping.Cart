#region References
using Cart.Contracts.Common;
using Cart.Contracts.Managers;
using Cart.Contracts.Repositories.OrderRepo;
using Cart.Entities.Common;
using Cart.Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Business.Managers
{
    public class OrderManager : IOrderManager
    {
        /// <summary>
        /// The order repository
        /// </summary>
        private readonly IOrderRepository _orderRepository;
        /// <summary>
        /// The custom logger
        /// </summary>
        private readonly ICustomLogger _customLogger;
        /// <summary>
        /// The order service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _orderServiceResponseErrorMapper;
        /// <summary>
        /// The service response mapper
        /// </summary>
        private readonly IMapper<object, ServiceResponse> _serviceResponseMapper;
        /// <summary>
        /// The error messages handler
        /// </summary>
        private readonly IErrorMessagesHandler _errorMessagesHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderManager"/> class.
        /// </summary>
        /// <param name="orderRepository">The order repository.</param>
        /// <param name="customLogger">The custom logger.</param>
        /// <param name="orderServiceResponseErrorMapper">The order service response error mapper.</param>
        /// <param name="serviceResponseMapper">The service response mapper.</param>
        /// <param name="errorMessagesHandler">The error messages handler.</param>
        public OrderManager(IOrderRepository orderRepository, ICustomLogger customLogger, IMapper<IList<Message>, ServiceResponse> orderServiceResponseErrorMapper, IMapper<object, ServiceResponse> serviceResponseMapper, IErrorMessagesHandler errorMessagesHandler)
        {
            _orderRepository = orderRepository;
            _customLogger = customLogger;
            _orderServiceResponseErrorMapper = orderServiceResponseErrorMapper;
            _serviceResponseMapper = serviceResponseMapper;
            _errorMessagesHandler = errorMessagesHandler;
        }
        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        public ServiceResponse GetOrder(OrderDTO order)
        {
            try
            {
                return _serviceResponseMapper.Map(_orderRepository.GetOrder(order));
            }
            catch (Exception ex)
            {
                _customLogger.LogError<OrderManager>(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <returns></returns>
        public ServiceResponse GetOrders()
        {
            try
            {
                var result = _orderRepository.GetOrders();
                return _serviceResponseMapper.Map(result);
            }
            catch (Exception ex)
            {
                _customLogger.LogError<OrderManager>(ex.StackTrace);
                throw;
            }
        }
    }
}
#endregion