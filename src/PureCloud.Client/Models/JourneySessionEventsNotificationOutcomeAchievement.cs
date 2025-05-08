using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationOutcomeAchievement
{
    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    public JourneySessionEventsNotificationOutcome Outcome { get; set; }

    /// <summary>
    /// Gets or Sets AchievedDate
    /// </summary>
    public DateTime? AchievedDate { get; set; }
}
