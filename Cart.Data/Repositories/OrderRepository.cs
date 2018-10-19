#region References
using Cart.Contracts.Common;
using Cart.Contracts.Repositories.OrderRepo;
using Cart.Data.CartModels;
using Cart.Entities.DataTransferObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

#region Namespace
namespace Cart.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// The shopping context
        /// </summary>
        private readonly ShoppingContext _shoppingContext;
        /// <summary>
        /// The entity mapper
        /// </summary>
        private readonly IEntityMapper _entityMapper;
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRepository"/> class.
        /// </summary>
        /// <param name="shoppingContext">The shopping context.</param>
        /// <param name="entityMapper">The entity mapper.</param>
        public OrderRepository(ShoppingContext shoppingContext, IEntityMapper entityMapper)
        {
            _shoppingContext = shoppingContext;
            _entityMapper = entityMapper;
        }
        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        public OrderDTO GetOrder(OrderDTO order)
        {
            try
            {
                var result = _shoppingContext.Orders.Where(o => o.Id == order.OrderId).FirstOrDefault();
                return _entityMapper.Map<Orders, OrderDTO>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderDTO> GetOrders()
        {
            try
            {
                var result = _shoppingContext.Orders.Include(i => i.OrderItem).ToList();
                return _entityMapper.Map<IEnumerable<Orders>, IEnumerable<OrderDTO>>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
#endregion
