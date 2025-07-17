using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestsResponse
{
    /// <summary>
    /// The Contest winning criteria
    /// </summary>
    /// <value>The Contest winning criteria</value>
    public ContestsResponseWinningCriteriaEnum? WinningCriteria { get; set; }

    /// <summary>
    /// The Contest anonymization
    /// </summary>
    /// <value>The Contest anonymization</value>
    public ContestsResponseAnonymizationEnum? Anonymization { get; set; }

    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    public ContestsResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division for this performance profile associate to
    /// </summary>
    /// <value>The division for this performance profile associate to</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// The Contest title
    /// </summary>
    /// <value>The Contest title</value>
    public string Title { get; set; }

    /// <summary>
    /// The Contest description
    /// </summary>
    /// <value>The Contest description</value>
    public string Description { get; set; }

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
    /// The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateAnnounced { get; set; }

    /// <summary>
    /// The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    public string AnnouncementTimezone { get; set; }

    /// <summary>
    /// The Contest&#39;s Metrics
    /// </summary>
    /// <value>The Contest&#39;s Metrics</value>
    public IEnumerable<ContestMetrics> Metrics { get; set; }

    /// <summary>
    /// The Contest Prizes
    /// </summary>
    /// <value>The Contest Prizes</value>
    public IEnumerable<ContestPrizes> Prizes { get; set; }

    /// <summary>
    /// The Contest Version
    /// </summary>
    /// <value>The Contest Version</value>
    public int? Version { get; set; }

    /// <summary>
    /// The creator of the contest
    /// </summary>
    /// <value>The creator of the contest</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    public ContestProfile Profile { get; set; }

    /// <summary>
    /// The Contest&#39;s participants
    /// </summary>
    /// <value>The Contest&#39;s participants</value>
    public IEnumerable<UserReference> Participants { get; set; }

    /// <summary>
    /// The Number of participants in the contest
    /// </summary>
    /// <value>The Number of participants in the contest</value>
    public int? ParticipantCount { get; set; }

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
    /// The Contest Winners
    /// </summary>
    /// <value>The Contest Winners</value>
    public IEnumerable<ContestWinners> Winners { get; set; }

    /// <summary>
    /// The Contest&#39;s disqualified agents, returned when a contest is complete
    /// </summary>
    /// <value>The Contest&#39;s disqualified agents, returned when a contest is complete</value>
    public IEnumerable<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
