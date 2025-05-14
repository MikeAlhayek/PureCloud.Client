using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationScorecardChangeTopicScorecardChange
{
    /// <summary>
    /// Gets or Sets Workday
    /// </summary>
    public string Workday { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public string DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets TeamId
    /// </summary>
    public string TeamId { get; set; }

    /// <summary>
    /// Gets or Sets PerformanceProfileId
    /// </summary>
    public string PerformanceProfileId { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets PerformanceMetrics
    /// </summary>
    public IEnumerable<GamificationScorecardChangeTopicPerformanceMetric> PerformanceMetrics { get; set; }
}
