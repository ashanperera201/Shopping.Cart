#region References
using Cart.Contracts.Common;
using Cart.Entities.Common;
using System;
#endregion

#region Namespace
namespace Cart.Resources
{
    public class ErrorMessageHandler : IErrorMessagesHandler
    {
        public Message Test()
        {
            throw new NotImplementedException();
        }
    }
}
#endregion