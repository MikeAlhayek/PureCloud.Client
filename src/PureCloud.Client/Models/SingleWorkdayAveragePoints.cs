using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class SingleWorkdayAveragePoints
{
    /// <summary>
    /// Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateWorkday { get; set; }

    /// <summary>
    /// The targeted division for the average points
    /// </summary>
    /// <value>The targeted division for the average points</value>
    public Division Division { get; set; }

    /// <summary>
    /// The average points per agent earned within the division
    /// </summary>
    /// <value>The average points per agent earned within the division</value>
    public double? AveragePoints { get; set; }

    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    public AddressableEntityRef PerformanceProfile { get; set; }
}
