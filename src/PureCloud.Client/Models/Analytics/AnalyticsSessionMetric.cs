namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// AnalyticsSessionMetric
/// </summary>

public sealed class AnalyticsSessionMetric
{
    /// <summary>
    /// Metric emission date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Metric emission date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EmitDate { get; set; }

    /// <summary>
    /// Unique name of this metric
    /// </summary>
    /// <value>Unique name of this metric</value>
    public string Name { get; set; }

    /// <summary>
    /// The metric value
    /// </summary>
    /// <value>The metric value</value>
    public long? Value { get; set; }
}
