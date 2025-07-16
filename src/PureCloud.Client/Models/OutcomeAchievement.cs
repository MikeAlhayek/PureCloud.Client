using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutcomeAchievement
{
    /// <summary>
    /// The outcome that was achieved.
    /// </summary>
    public AchievedOutcome Outcome { get; set; }

    /// <summary>
    /// Timestamp indicating when the outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? AchievedDate { get; set; }
}
