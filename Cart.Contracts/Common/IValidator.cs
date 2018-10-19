#region References
using Cart.Entities.Common;
using System;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Contracts.Common
{
    public interface IValidator<in T> : IDisposable
    {
        bool Validate(T obj, out IList<Message> messages);
    }
}
#endregion