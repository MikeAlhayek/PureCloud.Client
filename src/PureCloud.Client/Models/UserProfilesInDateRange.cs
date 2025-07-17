using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserProfilesInDateRange
{
    /// <summary>
    /// The query agent
    /// </summary>
    /// <value>The query agent</value>
    public UserReference User { get; set; }

    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// The list of profiles of the agent
    /// </summary>
    /// <value>The list of profiles of the agent</value>
    public IEnumerable<ProfileWithDateRange> Profiles { get; set; }
}
