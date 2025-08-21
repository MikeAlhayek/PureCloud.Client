using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebMessagingApi
{
    /// <summary>
    /// Get the messages for a web messaging session
    /// </summary>
    /// <param name="pageSize">Page size. The maximum number of messages to return per page. Default is 25. Valid range: 1-100.</param>
    /// <param name="pageNumber">Page number. The page number to retrieve. Default is 1. Must be 1 or greater.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of web messaging messages with pagination information.</returns>
    Task<WebMessagingMessageEntityList> GetWebMessagingMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
}
