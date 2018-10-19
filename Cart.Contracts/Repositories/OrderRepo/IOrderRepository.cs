#region References
using System;
using System.Collections.Generic;
using Cart.Entities.DataTransferObjects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Contracts.Repositories.OrderRepo
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrderDTO> GetOrders();
        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        OrderDTO GetOrder(OrderDTO order);
    }
}
#endregion