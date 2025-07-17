using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestsEssentials
{
    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    public ContestsEssentialsStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The Contest title
    /// </summary>
    /// <value>The Contest title</value>
    public string Title { get; set; }

    /// <summary>
    /// Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStart { get; set; }

    /// <summary>
    /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEnd { get; set; }

    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    public ContestProfile Profile { get; set; }

    /// <summary>
    /// The Number of participants in the contest
    /// </summary>
    /// <value>The Number of participants in the contest</value>
    public int? ParticipantCount { get; set; }

    /// <summary>
    /// The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateAnnounced { get; set; }

    /// <summary>
    /// The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateFinalized { get; set; }

    /// <summary>
    /// The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCancelled { get; set; }

    /// <summary>
    /// The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateScoresModified { get; set; }

    /// <summary>
    /// The Contest&#39;s Metrics
    /// </summary>
    /// <value>The Contest&#39;s Metrics</value>
    public IEnumerable<ContestMetrics> Metrics { get; set; }

    /// <summary>
    /// The Most Recent Contest Info for the requesting participant
    /// </summary>
    /// <value>The Most Recent Contest Info for the requesting participant</value>
    public ContestRequesingParticipantDailyInfo RequestingParticipantContestInfo { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
