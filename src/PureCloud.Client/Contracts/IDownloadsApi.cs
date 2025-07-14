using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IDownloadsApi
{
    Task<UrlResponse> GetDownloadAsync(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null, CancellationToken cancellationToken = default);
}
