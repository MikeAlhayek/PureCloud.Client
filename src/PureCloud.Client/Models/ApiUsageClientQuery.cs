namespace PureCloud.Client.Models;

public sealed class ApiUsageClientQuery
{
    public string Interval { get; set; }
    public ApiUsageClientQueryGranularityEnum? Granularity { get; set; }
    public IEnumerable<ApiUsageClientQueryMetricsEnum> Metrics { get; set; }
    public IEnumerable<ApiUsageClientQueryGroupByEnum> GroupBy { get; set; }
}