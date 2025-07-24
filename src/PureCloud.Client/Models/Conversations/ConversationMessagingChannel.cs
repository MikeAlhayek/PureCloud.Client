using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class ConversationMessagingChannel
{
    /// <summary>
    /// The provider type.
    /// </summary>
    /// <value>The provider type.</value>
    public ConversationMessagingChannelPlatformEnum? Platform { get; set; }

    public string Id { get; set; }

    public string MessageId { get; set; }

    public ConversationMessagingToRecipient To { get; set; }

    public ConversationMessagingFromRecipient From { get; set; }

    public DateTime? Time { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
