namespace PureCloud.Client.Models;

/// <summary>
/// Fields identifying the initiator of a given conversation command.
/// </summary>
public sealed class ConversationEventTopicTransferInitiator
{
    /// <summary>
    /// The id of the user who initiated the command if it was initiated by a user.
    /// </summary>
    /// <value>The id of the user who initiated the command if it was initiated by a user.</value>
    public string UserId { get; set; }
}
