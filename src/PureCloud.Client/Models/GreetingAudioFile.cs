using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GreetingAudioFile
{
    /// <summary>
    /// Gets or Sets DurationMilliseconds
    /// </summary>
    public long? DurationMilliseconds { get; set; }

    /// <summary>
    /// Gets or Sets SizeBytes
    /// </summary>
    public long? SizeBytes { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
