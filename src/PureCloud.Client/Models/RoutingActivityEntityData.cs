using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoutingActivityEntityData
{
    /// <summary>
    /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ActivityDate { get; set; }

    /// <summary>
    /// Organization presence identifier
    /// </summary>
    /// <value>Organization presence identifier</value>
    public string OrganizationPresenceId { get; set; }

    /// <summary>
    /// Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? PresenceDate { get; set; }

    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Queue membership status (e.g. active or inactive)
    /// </summary>
    /// <value>Queue membership status (e.g. active or inactive)</value>
    public string QueueMembershipStatus { get; set; }

    /// <summary>
    /// Agent routing status
    /// </summary>
    /// <value>Agent routing status</value>
    public string RoutingStatus { get; set; }

    /// <summary>
    /// Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? RoutingStatusDate { get; set; }

    /// <summary>
    /// System presence
    /// </summary>
    /// <value>System presence</value>
    public string SystemPresence { get; set; }

    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }
}
