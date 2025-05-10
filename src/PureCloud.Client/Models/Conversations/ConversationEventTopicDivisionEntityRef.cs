namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// ConversationEventTopicDivisionEntityRef
/// </summary>

public sealed class ConversationEventTopicDivisionEntityRef
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// The time the entity division was last updated.
    /// </summary>
    /// <value>The time the entity division was last updated.</value>
    public DateTime? DateDivisionUpdated { get; set; }
}
