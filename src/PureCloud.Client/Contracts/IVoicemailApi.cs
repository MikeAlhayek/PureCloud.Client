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

    /// <summary>
    /// Delete all voicemail messages
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if messages were deleted successfully</returns>
    Task<bool> DeleteVoicemailMessagesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a group's mailbox information
    /// </summary>
    /// <param name="groupId">Group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The group's mailbox information</returns>
    Task<VoicemailMailboxInfo> GetVoicemailGroupMailboxAsync(string groupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get voicemail messages for a group
    /// </summary>
    /// <param name="groupId">Group ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Group voicemail messages</returns>
    Task<VoicemailMessageEntityListing> GetVoicemailGroupMessagesAsync(string groupId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a group's voicemail policy
    /// </summary>
    /// <param name="groupId">Group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The group's voicemail policy</returns>
    Task<VoicemailGroupPolicy> GetVoicemailGroupPolicyAsync(string groupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current user's mailbox information
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The current user's mailbox information</returns>
    Task<VoicemailMailboxInfo> GetVoicemailMeMailboxAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current user's voicemail messages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Current user's voicemail messages</returns>
    Task<VoicemailMessageEntityListing> GetVoicemailMeMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current user's voicemail policy
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The current user's voicemail policy</returns>
    Task<VoicemailUserPolicy> GetVoicemailMePolicyAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get media information for a voicemail message
    /// </summary>
    /// <param name="messageId">Message ID</param>
    /// <param name="formatId">Format ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Voicemail media information</returns>
    Task<VoicemailMediaInfo> GetVoicemailMessageMediaAsync(string messageId, string formatId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get voicemail messages by IDs
    /// </summary>
    /// <param name="ids">Comma-separated list of voicemail message IDs</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Voicemail messages</returns>
    Task<VoicemailMessageEntityListing> GetVoicemailMessagesAsync(string ids = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the organization's voicemail policy
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The organization's voicemail policy</returns>
    Task<VoicemailOrganizationPolicy> GetVoicemailPolicyAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get voicemail messages for a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue voicemail messages</returns>
    Task<VoicemailMessageEntityListing> GetVoicemailQueueMessagesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search voicemails using GET method
    /// </summary>
    /// <param name="q64">Base64 encoded search query</param>
    /// <param name="expand">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Voicemails search response</returns>
    Task<VoicemailsSearchResponse> GetVoicemailSearchAsync(string q64, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's mailbox information
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user's mailbox information</returns>
    Task<VoicemailMailboxInfo> GetVoicemailUserMailboxAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get voicemail messages for a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User voicemail messages</returns>
    Task<VoicemailMessageEntityListing> GetVoicemailUserMessagesAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's voicemail policy
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user's voicemail policy</returns>
    Task<VoicemailUserPolicy> GetVoicemailUserPolicyAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a group's voicemail policy
    /// </summary>
    /// <param name="groupId">Group ID</param>
    /// <param name="body">Group voicemail policy</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated group voicemail policy</returns>
    Task<VoicemailGroupPolicy> PatchVoicemailGroupPolicyAsync(string groupId, VoicemailGroupPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a voicemail message
    /// </summary>
    /// <param name="messageId">Message ID</param>
    /// <param name="body">Voicemail message</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated voicemail message</returns>
    Task<VoicemailMessage> PatchVoicemailMessageAsync(string messageId, VoicemailMessage body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's voicemail policy
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">User voicemail policy</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user voicemail policy</returns>
    Task<VoicemailUserPolicy> PatchVoicemailUserPolicyAsync(string userId, VoicemailUserPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a voicemail message
    /// </summary>
    /// <param name="body">Copy voicemail message request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created voicemail message</returns>
    Task<VoicemailMessage> CreateVoicemailMessageAsync(CopyVoicemailMessage body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a voicemail message using PUT
    /// </summary>
    /// <param name="messageId">Message ID</param>
    /// <param name="body">Voicemail message</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated voicemail message</returns>
    Task<VoicemailMessage> UpdateVoicemailMessageAsync(string messageId, VoicemailMessage body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the organization's voicemail policy
    /// </summary>
    /// <param name="body">Organization voicemail policy</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated organization voicemail policy</returns>
    Task<VoicemailOrganizationPolicy> UpdateVoicemailPolicyAsync(VoicemailOrganizationPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's voicemail policy using PUT
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">User voicemail policy</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated user voicemail policy</returns>
    Task<VoicemailUserPolicy> UpdateVoicemailUserPolicyAsync(string userId, VoicemailUserPolicy body, CancellationToken cancellationToken = default);
}
