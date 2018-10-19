#region References
using Cart.Contracts.Common;
using Cart.Entities.Common;
using System;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Business.Mappers
{
    public class ServiceErrorMapper : IMapper<IList<Message>, ServiceResponse>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public ServiceResponse Map(IList<Message> input) => new ServiceResponse
        {
            IsError = true,
            Messages = input
        };
    }
}
#endregion
