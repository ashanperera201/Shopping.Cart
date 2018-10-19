#region References
using Cart.Entities.Common;
using Cart.Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Contracts.Managers
{
    public interface IOrderManager
    {
        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <returns></returns>
        ServiceResponse GetOrders();
        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        ServiceResponse GetOrder(OrderDTO order);

    }
}
#endregion