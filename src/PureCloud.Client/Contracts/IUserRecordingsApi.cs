using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Represents a collection of functions to interact with the User Recordings API endpoints
/// </summary>
public interface IUserRecordingsApi
{
    /// <summary>
    /// Delete a user recording
    /// </summary>
    /// <param name="recordingId">User Recording ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if deletion was successful</returns>
    Task<bool> DeleteUserRecordingAsync(string recordingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user recording
    /// </summary>
    /// <param name="recordingId">User Recording ID</param>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User recording details</returns>
    Task<UserRecording> GetUserRecordingAsync(string recordingId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Download a user recording
    /// </summary>
    /// <param name="recordingId">User Recording ID</param>
    /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Download response with recording data</returns>
    Task<DownloadResponse> GetUserRecordingTranscodingAsync(string recordingId, string formatId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of user recordings
    /// </summary>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of user recordings</returns>
    Task<UserRecordingEntityListing> GetUserRecordingsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user recording summary
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User recording summary</returns>
    Task<FaxSummary> GetUserRecordingsSummaryAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user recording
    /// </summary>
    /// <param name="recordingId">User Recording ID</param>
    /// <param name="body">UserRecording object with updates</param>
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user recording</returns>
    Task<UserRecording> UpdateUserRecordingAsync(string recordingId, UserRecording body, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);
}
