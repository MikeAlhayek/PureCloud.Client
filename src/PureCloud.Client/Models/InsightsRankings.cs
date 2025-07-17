using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsRankings
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    public InsightsRankingsGranularityEnum? Granularity { get; set; }

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
    /// The leaders users
    /// </summary>
    /// <value>The leaders users</value>
    public IEnumerable<InsightsSummaryUserItem> Leaders { get; set; }

    /// <summary>
    /// The trailing users
    /// </summary>
    /// <value>The trailing users</value>
    public IEnumerable<InsightsSummaryUserItem> Trailers { get; set; }
}
