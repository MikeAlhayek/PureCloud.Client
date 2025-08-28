using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebChatApi
{
    /// <summary>
    /// Get WebChat deployment settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat settings</returns>
    Task<WebChatSettings> GetWebchatSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a WebChat deployment
    /// </summary>
    /// <param name="deploymentId">Deployment Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat deployment</returns>
    Task<WebChatDeployment> GetWebchatDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List WebChat deployments
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat deployment entity listing</returns>
    Task<WebChatDeploymentEntityListing> GetWebchatDeploymentsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a web chat conversation member
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="memberId">Member Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat member info</returns>
    Task<WebChatMemberInfo> GetWebchatGuestConversationMemberAsync(string conversationId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the members of a chat conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="pageSize">The number of entries to return per page</param>
    /// <param name="pageNumber">The page number to return</param>
    /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat member info entity list</returns>
    Task<WebChatMemberInfoEntityList> GetWebchatGuestConversationMembersAsync(string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a web chat conversation message
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="messageId">Message Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat message</returns>
    Task<WebChatMessage> GetWebchatGuestConversationMessageAsync(string conversationId, string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the messages of a chat conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="after">If available, get the messages chronologically after the id of this message</param>
    /// <param name="before">If available, get the messages chronologically before the id of this message</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat message entity list</returns>
    Task<WebChatMessageEntityList> GetWebchatGuestConversationMessagesAsync(string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a media request in the conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="mediaRequestId">Media Request Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat guest media request</returns>
    Task<WebChatGuestMediaRequest> GetWebchatGuestConversationMediaRequestAsync(string conversationId, string mediaRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all media requests to the guest in the conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat guest media request entity list</returns>
    Task<WebChatGuestMediaRequestEntityList> GetWebchatGuestConversationMediaRequestsAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create WebChat deployment
    /// </summary>
    /// <param name="body">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat deployment</returns>
    Task<WebChatDeployment> CreateWebchatDeploymentAsync(WebChatDeployment body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create an ACD chat conversation from an external customer
    /// </summary>
    /// <param name="body">Create conversation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Create WebChat conversation response</returns>
    Task<CreateWebChatConversationResponse> CreateWebchatGuestConversationAsync(CreateWebChatConversationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send a message in a chat conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="memberId">Member Id</param>
    /// <param name="body">Message</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat message</returns>
    Task<WebChatMessage> CreateWebchatGuestConversationMemberMessageAsync(string conversationId, string memberId, CreateWebChatMessageRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send a typing-indicator in a chat conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="memberId">Member Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat typing</returns>
    Task<WebChatTyping> CreateWebchatGuestConversationMemberTypingAsync(string conversationId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a media request in the conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="mediaRequestId">Media Request Id</param>
    /// <param name="body">Media Request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat guest media request</returns>
    Task<WebChatGuestMediaRequest> UpdateWebchatGuestConversationMediaRequestAsync(string conversationId, string mediaRequestId, WebChatGuestMediaRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update WebChat deployment settings
    /// </summary>
    /// <param name="body">WebChat settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat settings</returns>
    Task<WebChatSettings> UpdateWebchatSettingsAsync(WebChatSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a WebChat deployment
    /// </summary>
    /// <param name="deploymentId">Deployment Id</param>
    /// <param name="body">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebChat deployment</returns>
    Task<WebChatDeployment> UpdateWebchatDeploymentAsync(string deploymentId, WebChatDeployment body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a WebChat deployment
    /// </summary>
    /// <param name="deploymentId">Deployment Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteWebchatDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a member from a chat conversation
    /// </summary>
    /// <param name="conversationId">Conversation Id</param>
    /// <param name="memberId">Member Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteWebchatGuestConversationMemberAsync(string conversationId, string memberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove WebChat deployment settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteWebchatSettingsAsync(CancellationToken cancellationToken = default);
}