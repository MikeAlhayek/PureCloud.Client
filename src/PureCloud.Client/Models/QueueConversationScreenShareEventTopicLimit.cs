using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationScreenShareEventTopicLimit
{
    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    public QueueConversationScreenShareEventTopicLimitNamespaceEnum? Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public long? Value { get; set; }

    /// <summary>
    /// Gets or Sets Documented
    /// </summary>
    public bool? Documented { get; set; }
}
