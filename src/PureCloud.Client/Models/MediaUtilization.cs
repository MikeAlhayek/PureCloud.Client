using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MediaUtilization
{
    /// <summary>
    /// Defines the maximum number of conversations of this type that an agent can handle at one time.
    /// </summary>
    /// <value>Defines the maximum number of conversations of this type that an agent can handle at one time.</value>
    public int? MaximumCapacity { get; set; }

    /// <summary>
    /// Defines the list of other media types that can interrupt a conversation of this media type.  Values include call, chat, email, callback, and message.
    /// </summary>
    /// <value>Defines the list of other media types that can interrupt a conversation of this media type.  Values include call, chat, email, callback, and message.</value>
    public IEnumerable<string> InterruptableMediaTypes { get; set; }

    /// <summary>
    /// If true, then track non-ACD conversations against utilization
    /// </summary>
    /// <value>If true, then track non-ACD conversations against utilization</value>
    public bool? IncludeNonAcd { get; set; }
}
