using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
        
namespace PureCloud.Client.Models;

public sealed class LearningModule
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool? ExcludedFromCatalog { get; set; }
    public UserReference CreatedBy { get; set; }
    public DateTime? DateCreated { get; set; }
    public UserReference ModifiedBy { get; set; }
    public DateTime? DateModified { get; set; }
    public int? Version { get; set; }
    public string ExternalId { get; set; }
    public LearningModuleSource Source { get; set; }
    public LearningModuleRule Rule { get; set; }
    public bool? EnforceContentOrder { get; set; }
    public ReviewAssessmentResults ReviewAssessmentResults { get; set; }
    public string SelfUri { get; set; }
    public bool? IsArchived { get; set; }
    public bool? IsPublished { get; set; }
    public string Description { get; set; }
    public int? CompletionTimeInDays { get; set; }
    public LearningModuleType Type { get; set; }
    public IEnumerable<LearningModuleInformStep> InformSteps { get; set; }
    public AssessmentForm AssessmentForm { get; set; }
    public LearningModuleSummary SummaryData { get; set; }
    public LearningModuleReassignSummary ReassignSummaryData { get; set; }
    public LearningModuleCoverArtResponse CoverArt { get; set; }
    public int? LengthInMinutes { get; set; }
    public ArchivalMode ArchivalMode { get; set; }
}
