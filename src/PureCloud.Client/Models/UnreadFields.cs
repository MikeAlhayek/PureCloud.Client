using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UnreadFields
{
    /// <summary>
    /// The new unread state of the alert
    /// </summary>
    /// <value>The new unread state of the alert</value>
    public bool? State { get; set; }
}
