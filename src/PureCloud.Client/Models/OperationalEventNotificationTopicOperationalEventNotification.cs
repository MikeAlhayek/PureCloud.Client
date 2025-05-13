using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OperationalEventNotificationTopicOperationalEventNotification
{
    /// <summary>
    /// Gets or Sets EventEntity
    /// </summary>
    public OperationalEventNotificationTopicEventEntity EventEntity { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    public Guid? EntityId { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    public string EntityName { get; set; }

    /// <summary>
    /// Gets or Sets PreviousValue
    /// </summary>
    public string PreviousValue { get; set; }

    /// <summary>
    /// Gets or Sets CurrentValue
    /// </summary>
    public string CurrentValue { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets ParentEntity
    /// </summary>
    public Guid? ParentEntity { get; set; }

    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public string EntityType { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets EntityToken
    /// </summary>
    public string EntityToken { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    public long? Timestamp { get; set; }
}
