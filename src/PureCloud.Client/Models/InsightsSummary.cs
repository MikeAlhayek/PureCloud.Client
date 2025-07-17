using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsSummary
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    public InsightsSummaryGranularityEnum? Granularity { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<InsightsSummaryUserItem> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

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
    /// Gets or Sets PageCount
    /// </summary>
    public int? PageCount { get; set; }
}
