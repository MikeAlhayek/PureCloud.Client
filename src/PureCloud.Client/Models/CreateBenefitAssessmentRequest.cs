using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateBenefitAssessmentRequest
{
    [JsonPropertyName("queueIds")]
    public IEnumerable<string> QueueIds { get; set; }
}