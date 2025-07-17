using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreatePerformanceProfile
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// A name for this performance profile
    /// </summary>
    /// <value>A name for this performance profile</value>
    public string Name { get; set; }

    /// <summary>
    /// The associated division for this Performance Profile
    /// </summary>
    /// <value>The associated division for this Performance Profile</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// A description about this performance profile
    /// </summary>
    /// <value>A description about this performance profile</value>
    public string Description { get; set; }

    /// <summary>
    /// Order of the associated metrics. The list should contain valid ids for metrics
    /// </summary>
    /// <value>Order of the associated metrics. The list should contain valid ids for metrics</value>
    public IEnumerable<string> MetricOrders { get; set; }

    /// <summary>
    /// Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The reporting interval periods for this performance profile
    /// </summary>
    /// <value>The reporting interval periods for this performance profile</value>
    public IEnumerable<ReportingInterval> ReportingIntervals { get; set; }

    /// <summary>
    /// The flag for active profiles
    /// </summary>
    /// <value>The flag for active profiles</value>
    public bool? Active { get; set; }

    /// <summary>
    /// The number of members in this performance profile
    /// </summary>
    /// <value>The number of members in this performance profile</value>
    public int? MemberCount { get; set; }

    /// <summary>
    /// The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries
    /// </summary>
    /// <value>The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries</value>
    public int? MaxLeaderboardRankSize { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
