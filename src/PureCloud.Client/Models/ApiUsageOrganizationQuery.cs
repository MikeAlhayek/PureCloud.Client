namespace PureCloud.Client.Models;

public sealed class ApiUsageOrganizationQuery
{
    public string Interval { get; set; }
    public ApiUsageOrganizationQueryGranularityEnum? Granularity { get; set; }
    public IEnumerable<ApiUsageOrganizationQueryMetricsEnum> Metrics { get; set; }
    public IEnumerable<ApiUsageOrganizationQueryGroupByEnum> GroupBy { get; set; }
}