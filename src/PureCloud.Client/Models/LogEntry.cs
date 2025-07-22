using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogEntry
/// </summary>
public sealed class LogEntry
{
    /// <summary>
    /// Level of log entry
    /// </summary>
    /// <value>Level of log entry</value>
    [JsonPropertyName("level")]
    public string Level { get; set; }

    /// <summary>
    /// Log message
    /// </summary>
    /// <value>Log message</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Timestamp of log entry
    /// </summary>
    /// <value>Timestamp of log entry</value>
    [JsonPropertyName("timestamp")]
    public long? Timestamp { get; set; }
}