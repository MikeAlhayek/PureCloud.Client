using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingToRecipient
{
    /// <summary>
    /// Gets or Sets IdType
    /// </summary>
    public V2ConversationMessageTypingEventForWorkflowTopicConversationMessagingToRecipientIdTypeEnum? IdType { get; set; }

    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    public string Nickname { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalIds
    /// </summary>
    public IEnumerable<V2ConversationMessageTypingEventForWorkflowTopicConversationRecipientAdditionalIdentifier> AdditionalIds { get; set; }
}
