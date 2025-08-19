using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebMessagingApi
{
    /// <summary>
    /// Get the messages for a web messaging session
    /// </summary>
    /// <param name="pageSize">Page size (optional, default 25)</param>
    /// <param name="pageNumber">Page number (optional, default 1)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A task representing the asynchronous operation containing the web messaging messages</returns>
    Task<WebMessagingMessageEntityList> GetWebMessagingMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
}
