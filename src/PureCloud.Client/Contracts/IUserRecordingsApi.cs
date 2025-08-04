using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IUserRecordingsApi
{
    /// <summary>
    /// Delete a user recording
    /// </summary>
    Task<bool> DeleteUserRecordingAsync(string recordingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user recording
    /// </summary>
    Task<UserRecording> GetUserRecordingAsync(string recordingId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Download a user recording
    /// </summary>
    Task<DownloadResponse> GetUserRecordingTranscodingAsync(string recordingId, string formatId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of user recordings
    /// </summary>
    Task<UserRecordingEntityListing> GetUserRecordingsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user recording summary
    /// </summary>
    Task<FaxSummary> GetUserRecordingsSummaryAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user recording
    /// </summary>
    Task<UserRecording> UpdateUserRecordingAsync(string recordingId, UserRecording body, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);
}