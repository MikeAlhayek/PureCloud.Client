namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// Fields identifying the entity that updated the command.
/// </summary>
public sealed class ConversationEventTopicTransferModifiedBy
{
    /// <summary>
    /// The id of the user if the updater is an internal user.
    /// </summary>
    /// <value>The id of the user if the updater is an internal user.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for the user if the updater is an internal user.
    /// </summary>
    /// <value>The URI for the user if the updater is an internal user.</value>
    public string SelfUri { get; set; }
}
