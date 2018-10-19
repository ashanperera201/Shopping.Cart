#region References
using Cart.Contracts.Common;
using Cart.Entities.Common;
using System;
#endregion

#region Namespace
namespace Cart.Business.Mappers
{
    public class ServiceResponseMapper : IMapper<Object, ServiceResponse>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public ServiceResponse Map(object input)
        {
            return new ServiceResponse
            {
                ReturnObject = input,
                IsError = false
            };
        }
    }
}
#endregion
