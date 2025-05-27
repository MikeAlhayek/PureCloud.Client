using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsRoutingStatusRecord
{
    /// <summary>
    /// The user's ACD routing status
    /// </summary>
    /// <value>The user's ACD routing status</value>
    public AnalyticsRoutingStatusRecordRoutingStatusEnum? RoutingStatus { get; set; }

    /// <summary>
    /// The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndTime { get; set; }
}
