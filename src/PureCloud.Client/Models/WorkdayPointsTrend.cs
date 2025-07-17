using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkdayPointsTrend
{
    /// <summary>
    /// Aggregated for same day comparison
    /// </summary>
    /// <value>Aggregated for same day comparison</value>
    public WorkdayPointsTrendDayOfWeekEnum? DayOfWeek { get; set; }

    /// <summary>
    /// The start workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// The targeted user for the query
    /// </summary>
    /// <value>The targeted user for the query</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The total average points
    /// </summary>
    /// <value>The total average points</value>
    public double? AveragePoints { get; set; }

    /// <summary>
    /// Daily points trends
    /// </summary>
    /// <value>Daily points trends</value>
    public IEnumerable<WorkdayPointsTrendItem> Trend { get; set; }
}
