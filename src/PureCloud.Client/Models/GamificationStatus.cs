using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationStatus
{
    /// <summary>
    /// Gamification status of the organization.
    /// </summary>
    /// <value>Gamification status of the organization.</value>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStart { get; set; }

    /// <summary>
    /// Automatic assignment of users to the default profile
    /// </summary>
    /// <value>Automatic assignment of users to the default profile</value>
    public bool? AutomaticUserAssignment { get; set; }

    /// <summary>
    /// Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartPersonalBest { get; set; }
}
