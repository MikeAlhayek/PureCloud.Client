namespace PureCloud.Client.Models;

public sealed class BenefitAssessment
{
    public string Id { get; set; }
    public BenefitAssessmentState? State { get; set; }
    public IEnumerable<object> Queues { get; set; }
    public IEnumerable<object> KpiAssessments { get; set; }
    public string JobId { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public string SelfUri { get; set; }
}