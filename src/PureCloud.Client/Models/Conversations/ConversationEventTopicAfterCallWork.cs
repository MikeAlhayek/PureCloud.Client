namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// A communication&#39;s after-call work data.
/// </summary>

public sealed class ConversationEventTopicAfterCallWork
{
    /// <summary>
    /// The communication's after-call work state.
    /// </summary>
    /// <value>The communication's after-call work state.</value>
    public ConversationEventTopicAfterCallWorkState? State { get; set; }

    /// <summary>
    /// The timestamp when this communication started after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication started after-call work in the cloud clock.</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The timestamp when this communication ended after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication ended after-call work in the cloud clock.</value>
    public DateTime? EndTime { get; set; }
}
