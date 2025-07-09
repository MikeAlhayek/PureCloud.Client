using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectJobMessage
{
    /// <summary>
    /// The message type.
    /// </summary>
    /// <value>The message type.</value>
    public ArchitectJobMessageTypeEnum? Type { get; set; }

    /// <summary>
    /// The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// The text of the message.
    /// </summary>
    /// <value>The text of the message.</value>
    public string Text { get; set; }
}
