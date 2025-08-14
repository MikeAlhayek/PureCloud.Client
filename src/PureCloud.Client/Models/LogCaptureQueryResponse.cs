using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LogCaptureQueryResponse
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<LogEntry> Entities { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    public string PreviousUri { get; set; }
}

