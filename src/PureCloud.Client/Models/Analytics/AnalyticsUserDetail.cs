using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsUserDetail
{
    /// <summary>
    /// The identifier for the user
    /// </summary>
    /// <value>The identifier for the user</value>
    public string UserId { get; set; }

    /// <summary>
    /// The presence records for the user
    /// </summary>
    /// <value>The presence records for the user</value>
    public IEnumerable<AnalyticsUserPresenceRecord> PrimaryPresence { get; set; }

    /// <summary>
    /// The ACD routing status records for the user
    /// </summary>
    /// <value>The ACD routing status records for the user</value>
    public IEnumerable<AnalyticsRoutingStatusRecord> RoutingStatus { get; set; }
}
