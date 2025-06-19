using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertRequest
{
    /// <summary>
    /// The action being taken on the alert.
    /// </summary>
    /// <value>The action being taken on the alert.</value>
    public AlertRequestTypeEnum? Type { get; set; }

    /// <summary>
    /// The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    public UnreadFields Unread { get; set; }

    /// <summary>
    /// Gets or Sets ValidRequest
    /// </summary>
    public bool? ValidRequest { get; set; }
}
