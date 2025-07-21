using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebMessagingApi
{
    Task<string> GetMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
}