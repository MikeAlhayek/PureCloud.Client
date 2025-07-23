using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BenefitAssessment
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("state")]
    public BenefitAssessmentState? State { get; set; }

    [JsonPropertyName("queues")]
    public IEnumerable<object> Queues { get; set; }

    [JsonPropertyName("kpiAssessments")]
    public IEnumerable<object> KpiAssessments { get; set; }

    [JsonPropertyName("jobId")]
    public string JobId { get; set; }

    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }

    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }
}