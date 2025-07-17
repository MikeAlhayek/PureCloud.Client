using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OverallBestPointsItem
{
    /// <summary>
    /// Best points aggregation interval granularity
    /// </summary>
    /// <value>Best points aggregation interval granularity</value>
    public OverallBestPointsItemGranularityTypeEnum? GranularityType { get; set; }

    /// <summary>
    /// List of associated users with the equal points.
    /// </summary>
    /// <value>List of associated users with the equal points.</value>
    public IEnumerable<UserReference> Users { get; set; }

    /// <summary>
    /// The count of the user IDs in the list
    /// </summary>
    /// <value>The count of the user IDs in the list</value>
    public int? Count { get; set; }

    /// <summary>
    /// Gamification points
    /// </summary>
    /// <value>Gamification points</value>
    public int? Points { get; set; }

    /// <summary>
    /// Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }
}
