using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILogCaptureApi
{
    /// <summary>
    /// Disable browser log capture for the user
    /// </summary>
    /// <param name="userId">The user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets status of async download execution
    /// </summary>
    /// <param name="jobId">The job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get log capture configuration for the user
    /// </summary>
    /// <param name="userId">The user ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all log capture enabled users for an org
    /// </summary>
    /// <param name="includeExpired">Include expired users</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an async download execution
    /// </summary>
    /// <param name="body">Query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogCaptureDownloadExecutionResponse> CreateDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query collected log entries
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="body">Query request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogCaptureQueryResponse> CreateDiagnosticsLogcaptureBrowserEntriesQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enable log capture for a user or update expiration
    /// </summary>
    /// <param name="userId">The user ID</param>
    /// <param name="body">User configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogCaptureUserConfiguration> CreateDiagnosticsLogcaptureBrowserUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default);
}
