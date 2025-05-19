using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCallbackEventTopicLimit
{
    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    public ConversationCallbackEventTopicLimitNamespaceEnum? Namespace { get; set; }

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
