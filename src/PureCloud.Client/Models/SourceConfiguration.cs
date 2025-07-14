using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SourceConfiguration
{
    /// <summary>
    /// Identifies the external platform that is the source of the conversation.
    /// </summary>
    /// <value>Identifies the external platform that is the source of the conversation.</value>
    public string SourceId { get; set; }

    /// <summary>
    /// The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.
    /// </summary>
    /// <value>The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.</value>
    public string InteractionId { get; set; }

    /// <summary>
    /// The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.
    /// </summary>
    /// <value>The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.</value>
    public string TagId { get; set; }
}
