using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public partial class UserBestPointsItem
{
    /// <summary>
    /// Best points aggregation interval granularity
    /// </summary>
    /// <value>Best points aggregation interval granularity</value>
    public UserBestPointsItemGranularityTypeEnum? GranularityType { get; set; }

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

    /// <summary>
    /// The rank of this user
    /// </summary>
    /// <value>The rank of this user</value>
    public int? Rank { get; set; }
}
