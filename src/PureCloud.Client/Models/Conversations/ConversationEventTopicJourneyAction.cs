namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)
/// </summary>
public sealed class ConversationEventTopicJourneyAction
{
    /// <summary>
    /// The ID of an action from the Journey System (an action is spawned from an actionMap)
    /// </summary>
    /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public ConversationEventTopicJourneyActionMap ActionMap { get; set; }
}
