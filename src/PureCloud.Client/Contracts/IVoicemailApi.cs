using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IVoicemailApi
{
    /// <summary>
    /// Get a voicemail message
    /// </summary>
    Task<VoicemailMessageClean> GetVoicemailMessageAsync(string messageId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a voicemail message
    /// </summary>
    Task<bool> DeleteVoicemailMessageAsync(string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current user's mailbox information
    /// </summary>
    Task<VoicemailMailboxInfoClean> GetVoicemailMailboxAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the current user's voicemail policy
    /// </summary>
    Task<VoicemailUserPolicyClean> PatchVoicemailMePolicyAsync(VoicemailUserPolicyClean body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search voicemails
    /// </summary>
    Task<VoicemailsSearchResponseClean> SearchVoicemailsAsync(VoicemailSearchRequestClean body, CancellationToken cancellationToken = default);
}