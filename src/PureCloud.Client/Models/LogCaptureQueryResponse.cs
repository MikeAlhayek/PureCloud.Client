using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureQueryResponse
/// </summary>
public sealed class LogCaptureQueryResponse
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<LogEntry> Entities { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }
}
