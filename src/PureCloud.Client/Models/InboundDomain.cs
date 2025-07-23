using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InboundDomain
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("mxRecordStatus")]
    public string MxRecordStatus { get; set; }

    [JsonPropertyName("subDomain")]
    public bool? SubDomain { get; set; }

    [JsonPropertyName("mailFromSettings")]
    public object MailFromSettings { get; set; }

    [JsonPropertyName("customSMTPServer")]
    public object CustomSMTPServer { get; set; }

    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }
}