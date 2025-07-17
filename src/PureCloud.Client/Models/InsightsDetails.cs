using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsDetails
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    public InsightsDetailsGranularityEnum? Granularity { get; set; }

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
    /// The list of insights data for each metric of the user
    /// </summary>
    /// <value>The list of insights data for each metric of the user</value>
    public IEnumerable<InsightsDetailsMetricItem> MetricData { get; set; }

    /// <summary>
    /// Overall insights data of the user
    /// </summary>
    /// <value>Overall insights data of the user</value>
    public InsightsDetailsOverallItem OverallData { get; set; }
}
