#region References
#endregion

#region Namespace
namespace Cart.Contracts.Common
{
    public interface ICustomLogger
    {
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        void LogError<T>(string message);
        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        void LogWarning<T>(string message);
        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        void LogMessage<T>(string message);
    }
}
#endregion