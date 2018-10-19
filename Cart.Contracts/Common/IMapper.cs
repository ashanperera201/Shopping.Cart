#region References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Namespace
namespace Cart.Contracts.Common
{
    public interface IMapper<in TInput, out TOutput>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        TOutput Map(TInput input);
    }
}
#endregion