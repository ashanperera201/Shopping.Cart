#region References
using System;
using System.Collections.Generic;
#endregion

#region Namespace
namespace Cart.Entities.Common
{
    public class ServiceResponse
    {
        /// <summary>
        /// Gets or sets the return object.
        /// </summary>
        public Object ReturnObject { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is error
        /// </summary>
        public bool IsError { get; set; }
        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public IList<Message> Messages { get; set; }
    }
}
#endregion
