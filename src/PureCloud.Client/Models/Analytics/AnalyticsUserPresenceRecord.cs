using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsUserPresenceRecord
{
    /// <summary>
    /// The user's system presence
    /// </summary>
    /// <value>The user's system presence</value>
    public AnalyticsUserPresenceRecordSystemPresenceEnum? SystemPresence { get; set; }

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

    /// <summary>
    /// The identifier for the user&#39;s organization presence
    /// </summary>
    /// <value>The identifier for the user&#39;s organization presence</value>
    public string OrganizationPresenceId { get; set; }
}
