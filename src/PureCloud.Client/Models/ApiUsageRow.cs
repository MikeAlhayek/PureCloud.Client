namespace PureCloud.Client.Models;

public sealed class ApiUsageRow
{
    public string ClientId { get; set; }
    public string ClientName { get; set; }
    public string OrganizationId { get; set; }
    public string UserId { get; set; }
    public string TemplateUri { get; set; }
    public string HttpMethod { get; set; }
    public long? Status200 { get; set; }
    public long? Status300 { get; set; }
    public long? Status400 { get; set; }
    public long? Status500 { get; set; }
    public long? Status429 { get; set; }
    public long? Requests { get; set; }
    public DateTime? Date { get; set; }
}