namespace PureCloud.Client.Models;

public sealed class ApiUsageSimpleSearch
{
    public string Interval { get; set; }
    public IEnumerable<ApiUsageSimpleSearchMetricsEnum> Metrics { get; set; }
    public IEnumerable<string> OauthClientNames { get; set; }
    public IEnumerable<ApiUsageSimpleSearchHttpMethodsEnum> HttpMethods { get; set; }
    public IEnumerable<string> TemplateUris { get; set; }
}