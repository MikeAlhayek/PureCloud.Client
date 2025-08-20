using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LogEntry
{
    /// <summary>
    /// Level of log entry
    /// </summary>
    public string Level { get; set; }

    /// <summary>
    /// Log message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Timestamp of log entry
    /// </summary>
    public long? Timestamp { get; set; }
}
