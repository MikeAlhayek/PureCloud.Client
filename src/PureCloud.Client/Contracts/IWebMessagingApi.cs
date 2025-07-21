using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebMessagingApi
{
    /// <summary>
    /// Gets web messaging messages
    /// </summary>
    /// <param name="pageSize">Page size (optional, default 25)</param>
    /// <param name="pageNumber">Page number (optional, default 1)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A task representing the asynchronous operation containing the messages response</returns>
    Task<string> GetMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
}
