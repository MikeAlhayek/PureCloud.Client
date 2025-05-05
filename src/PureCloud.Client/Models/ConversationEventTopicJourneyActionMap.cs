namespace PureCloud.Client.Models;

/// <summary>
/// Details about the action map from the Journey System which triggered this action
/// </summary>
public sealed class ConversationEventTopicJourneyActionMap
{
    /// <summary>
    /// The ID of the actionMap in the Journey System which triggered this action
    /// </summary>
    /// <value>The ID of the actionMap in the Journey System which triggered this action</value>
    public string Id { get; set; }

    /// <summary>
    /// The version number of the actionMap in the Journey System at the time this action was triggered
    /// </summary>
    /// <value>The version number of the actionMap in the Journey System at the time this action was triggered</value>
    public long? Version { get; set; }
}
