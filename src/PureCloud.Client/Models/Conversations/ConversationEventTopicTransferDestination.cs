namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// Fields identifying the destination of a given conversation command.
/// </summary>
public sealed class ConversationEventTopicTransferDestination
{
    /// <summary>
    /// The id of the user if the command destination is a user.
    /// </summary>
    /// <value>The id of the user if the command destination is a user.</value>
    public string UserId { get; set; }

    /// <summary>
    /// The destination address if the command destination is an endpoint.
    /// </summary>
    /// <value>The destination address if the command destination is an endpoint.</value>
    public string Address { get; set; }
}
