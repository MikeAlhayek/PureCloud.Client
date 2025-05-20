using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PersistentConnectionChangeTopicErrorInfo
{
    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets UserMessage
    /// </summary>
    public string UserMessage { get; set; }

    /// <summary>
    /// Gets or Sets UserParams
    /// </summary>
    public Dictionary<string, string> UserParams { get; set; }

    /// <summary>
    /// Gets or Sets NestedErrorDetails
    /// </summary>
    public IEnumerable<PersistentConnectionChangeTopicErrorInfoDetails> NestedErrorDetails { get; set; }
}
