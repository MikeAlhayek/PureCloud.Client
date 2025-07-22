using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILogCaptureApi
{
    /// <summary>
    /// Get log capture configuration for the user
    /// </summary>
    Task<LogCaptureUserConfiguration> GetLogCaptureUserConfigurationAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all log capture enabled users for an org
    /// </summary>
    Task<PagelessEntityListing> GetLogCaptureUsersAsync(bool? includeExpired = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets status of async download execution
    /// </summary>
    Task<LogCaptureDownloadExecutionResponse> GetLogCaptureDownloadJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an async download execution
    /// </summary>
    Task<LogCaptureDownloadExecutionResponse> CreateLogCaptureDownloadJobAsync(LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
    /// </summary>
    Task<LogCaptureQueryResponse> CreateLogCaptureQueryAsync(string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disable browser log capture for the user
    /// </summary>
    Task DeleteLogCaptureUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enable log capture for a user or update expiration
    /// </summary>
    Task<LogCaptureUserConfiguration> CreateLogCaptureUserAsync(string userId, LogCaptureUserConfiguration body = null, CancellationToken cancellationToken = default);
}