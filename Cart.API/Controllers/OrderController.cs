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
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        /// <summary>
        /// The order manager
        /// </summary>
        private readonly IOrderManager _orderManager;
        /// <summary>
        /// The custom logger
        /// </summary>
        private readonly ICustomLogger _customLogger;
        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;
        /// <summary>
        /// The error messages handler
        /// </summary>
        private readonly IErrorMessagesHandler _errorMessagesHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="orderManager">The order manager.</param>
        /// <param name="customLogger">The custom logger.</param>
        /// <param name="serviceResponseErrorMapper">The service response error mapper.</param>
        /// <param name="errorMessagesHandler">The error messages handler.</param>
        public OrderController(IOrderManager orderManager, ICustomLogger customLogger, IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper, IErrorMessagesHandler errorMessagesHandler)
        {
            _orderManager = orderManager;
            _customLogger = customLogger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _errorMessagesHandler = errorMessagesHandler;
        }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <returns></returns>
        [HttpGet("orders")]
        public ServiceResponse GetOrders()
        {
            try
            {
                return _orderManager.GetOrders();
            }
            catch (Exception ex)
            {
                _customLogger.LogError<OrderController>(ex.StackTrace);
                throw;
            }
        }

        [HttpPost("order")]
        public ServiceResponse GetOrder(OrderDTO order)
        {
            try
            {
                if (order != null)
                {
                    return _orderManager.GetOrder(order);
                }
                else
                {
                    //set later to error mapper
                    return null;
                }
            }
            catch (Exception ex)
            {
                _customLogger.LogError<OrderController>(ex.StackTrace);
                throw ex;
            }
        }
    }
}
#endregion