using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IScreenRecordingApi
{
    /// <summary>
    /// Sign identifying information for screen recording
    /// </summary>
    Task<SignedData> CreateScreenrecordingTokenAsync(ScreenRecordingUserAuthenticatedInfo body = null, CancellationToken cancellationToken = default);
}