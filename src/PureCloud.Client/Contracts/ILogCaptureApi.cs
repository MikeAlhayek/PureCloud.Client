using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILogCaptureApi
{
    /// <summary>
    /// Disable browser log capture for the user
    /// </summary>
    Task<bool> DeleteDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets status of async download execution
    /// </summary>
    Task<LogCaptureDownloadExecutionResponse> GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get log capture configuration for the user
    /// </summary>
    Task<LogCaptureUserConfiguration> GetDiagnosticsLogcaptureBrowserUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all log capture enabled users for an org
    /// </summary>
    Task<PagelessEntityListing> GetDiagnosticsLogcaptureBrowserUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an async download execution
    /// </summary>
    Task<LogCaptureDownloadExecutionResponse> CreateDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query collected log entries
    /// </summary>
    Task<LogCaptureQueryResponse> CreateDiagnosticsLogcaptureBrowserEntriesQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enable log capture for a user or update expiration
    /// </summary>
    Task<LogCaptureUserConfiguration> CreateDiagnosticsLogcaptureBrowserUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default);
}