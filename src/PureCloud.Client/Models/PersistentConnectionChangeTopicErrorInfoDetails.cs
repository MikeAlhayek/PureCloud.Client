using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PersistentConnectionChangeTopicErrorInfoDetails
{
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
    /// Gets or Sets Hostname
    /// </summary>
    public string Hostname { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    public PersistentConnectionChangeTopicErrorLocation Location { get; set; }
}
