using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestsCreateRequest
{
    /// <summary>
    /// The Contest winning criteria
    /// </summary>
    /// <value>The Contest winning criteria</value>
    public ContestsCreateRequestWinningCriteriaEnum? WinningCriteria { get; set; }

    /// <summary>
    /// The Contest anonymization
    /// </summary>
    /// <value>The Contest anonymization</value>
    public ContestsCreateRequestAnonymizationEnum? Anonymization { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division for this performance profile associate to. Only set for DEFAULT profile.
    /// </summary>
    /// <value>The division for this performance profile associate to. Only set for DEFAULT profile.</value>
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
    /// The Contest profile
    /// </summary>
    /// <value>The Contest profile</value>
    public string ProfileId { get; set; }

    /// <summary>
    /// The Contest&#39;s participants
    /// </summary>
    /// <value>The Contest&#39;s participants</value>
    public IEnumerable<string> ParticipantIds { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
