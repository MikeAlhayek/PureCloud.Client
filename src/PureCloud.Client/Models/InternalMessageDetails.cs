namespace PureCloud.Client.Models;

public sealed class InternalMessageDetails
{
    /// <summary>
    /// UUID identifying the internal message media.
    /// </summary>
    /// <value>UUID identifying the internal message media.</value>
    public string MessageId { get; set; }

    /// <summary>
    /// The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? MessageTime { get; set; }
}
