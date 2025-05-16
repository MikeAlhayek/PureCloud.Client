using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationVideoEventTopicDisconnectReason
{
    /// <summary>
    /// Disconnect reason protocol type.
    /// </summary>
    /// <value>Disconnect reason protocol type.</value>
    public QueueConversationVideoEventTopicDisconnectReasonTypeEnum? Type { get; set; }

    /// <summary>
    /// Protocol specific reason code. See the Q.850 and SIP specs.
    /// </summary>
    /// <value>Protocol specific reason code. See the Q.850 and SIP specs.</value>
    public long? Code { get; set; }

    /// <summary>
    /// Human readable English description of the disconnect reason.
    /// </summary>
    /// <value>Human readable English description of the disconnect reason.</value>
    public string Phrase { get; set; }
}
