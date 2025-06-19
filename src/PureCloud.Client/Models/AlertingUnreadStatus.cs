using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertingUnreadStatus
{
    /// <summary>
    /// True is alert is unread, false if it has not been.
    /// </summary>
    /// <value>True is alert is unread, false if it has not been.</value>
    public bool? Unread { get; set; }
}
