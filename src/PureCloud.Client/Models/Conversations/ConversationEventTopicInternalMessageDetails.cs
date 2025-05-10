namespace PureCloud.Client.Models.Conversations;

public sealed class ConversationEventTopicInternalMessageDetails
{
    /// <summary>
    /// UUID identifying the internal message media.
    /// </summary>
    /// <value>UUID identifying the internal message media.</value>
    public string MessageId { get; set; }

    /// <summary>
    /// The time when the internal message was sent or received.
    /// </summary>
    /// <value>The time when the internal message was sent or received.</value>
    public DateTime? MessageTime { get; set; }
}
