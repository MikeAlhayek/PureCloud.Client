using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILogCaptureApi
{
    Task DeleteLogCaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<LogCaptureDownloadExecutionResponse> GetLogCaptureDownloadJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<LogCaptureUserConfiguration> GetLogCaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<PagelessEntityListing> GetLogCaptureBrowserUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default);

    Task<LogCaptureDownloadExecutionResponse> CreateLogCaptureDownloadJobAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    Task<LogCaptureQueryResponse> CreateLogCaptureEntriesQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    Task<LogCaptureUserConfiguration> CreateLogCaptureBrowserUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default);
}