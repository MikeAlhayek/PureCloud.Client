namespace PureCloud.Client.Models;

public sealed class TransferInitiator
{
    /// <summary>
    /// The id of the user who initiated the command if it was initiated by a user.
    /// </summary>
    /// <value>The id of the user who initiated the command if it was initiated by a user.</value>
    public string UserId { get; set; }
}
