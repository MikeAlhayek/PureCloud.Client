namespace PureCloud.Client.Models;

/// <summary>
/// JourneyViewChartMetricResult
/// </summary>
public sealed class JourneyViewChartMetricResult
{
    /// <summary>
    /// JourneyViewChartMetricResult
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Metric result values
    /// </summary>
    public IEnumerable<JourneyViewChartMetricResultValue> Values { get; set; }
}
