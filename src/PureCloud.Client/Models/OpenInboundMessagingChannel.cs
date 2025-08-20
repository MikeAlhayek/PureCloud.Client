namespace PureCloud.Client.Models;

/// <summary>
/// Open Channel-specific information that describes the message and the message channel/provider.
/// </summary>
public sealed class OpenInboundMessagingChannel
{
    /// <summary>
    /// Information about the recipient the message is received from.
    /// </summary>
    public OpenMessagingFromRecipient From { get; set; }


    /// <summary>
    /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? Time { get; set; }
}
