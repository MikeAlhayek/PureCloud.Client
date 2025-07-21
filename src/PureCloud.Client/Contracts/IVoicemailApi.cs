using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IVoicemailApi
{
    /// <summary>
    /// Get a voicemail message
    /// </summary>
    /// <param name="messageId">The ID of the voicemail message</param>
    /// <param name="expand">If the caller is a known user, which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The voicemail message</returns>
    Task<VoicemailMessage> GetVoicemailMessageAsync(string messageId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a voicemail message
    /// </summary>
    /// <param name="messageId">The ID of the voicemail message</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the message was deleted successfully</returns>
    Task<bool> DeleteVoicemailMessageAsync(string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current user's mailbox information
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The current user's mailbox information</returns>
    Task<VoicemailMailboxInfo> GetVoicemailMailboxAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the current user's voicemail policy
    /// </summary>
    /// <param name="body">The user's voicemail policy</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated voicemail policy</returns>
    Task<VoicemailUserPolicy> PatchVoicemailMePolicyAsync(VoicemailUserPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search voicemails
    /// </summary>
    /// <param name="body">Search request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Voicemails search response</returns>
    Task<VoicemailsSearchResponse> SearchVoicemailsAsync(VoicemailSearchRequest body, CancellationToken cancellationToken = default);
}
