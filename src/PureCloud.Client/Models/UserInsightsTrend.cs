using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserInsightsTrend
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    public UserInsightsTrendGranularityEnum? Granularity { get; set; }

    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    public AddressableEntityRef PerformanceProfile { get; set; }

    /// <summary>
    /// The division
    /// </summary>
    /// <value>The division</value>
    public DivisionReference Division { get; set; }

    /// <summary>
    /// The comparative period work day date range
    /// </summary>
    /// <value>The comparative period work day date range</value>
    public WorkdayPeriod ComparativePeriod { get; set; }

    /// <summary>
    /// The primary period work day date range
    /// </summary>
    /// <value>The primary period work day date range</value>
    public WorkdayPeriod PrimaryPeriod { get; set; }

    /// <summary>
    /// The query user
    /// </summary>
    /// <value>The query user</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The list of insights trend for each metric
    /// </summary>
    /// <value>The list of insights trend for each metric</value>
    public IEnumerable<UserInsightsTrendMetricItem> Entities { get; set; }

    /// <summary>
    /// The insights trend in total
    /// </summary>
    /// <value>The insights trend in total</value>
    public UserInsightsTrendTotalItem Total { get; set; }
}
