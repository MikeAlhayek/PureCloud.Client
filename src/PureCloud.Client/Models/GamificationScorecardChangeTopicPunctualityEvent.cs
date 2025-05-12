using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationScorecardChangeTopicPunctualityEvent
{
    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    public string DateStart { get; set; }

    /// <summary>
    /// Gets or Sets DateScheduleStart
    /// </summary>
    public string DateScheduleStart { get; set; }

    /// <summary>
    /// Gets or Sets ActivityCode
    /// </summary>
    public string ActivityCode { get; set; }

    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    public long? Points { get; set; }
}
