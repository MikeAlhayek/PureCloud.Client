namespace PureCloud.Client.Models;

public sealed class ComparisonPeriod
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Key Performance Indicator optimised during the comparison period.
    /// </summary>
    public string Kpi { get; set; }

    /// <summary>
    /// Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateStarted { get; set; }

    /// <summary>
    /// End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateEnded { get; set; }

    /// <summary>
    /// The percentage benefit on this queue for the duration of the comparison period
    /// </summary>
    public double? PercentageBenefit { get; set; }

    /// <summary>
    /// KPI results for each metric
    /// </summary>
    public IEnumerable<KpiResult> KpiResults { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
