using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EvaluationQualityV2TopicEvaluationV2
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public EvaluationQualityV2TopicEvaluationV2StatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets PreviousStatus
    /// </summary>
    public EvaluationQualityV2TopicEvaluationV2PreviousStatusEnum? PreviousStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public EvaluationQualityV2TopicUser Agent { get; set; }

    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    public EvaluationQualityV2TopicUser Evaluator { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationFormId
    /// </summary>
    public string EvaluationFormId { get; set; }

    /// <summary>
    /// Gets or Sets FormName
    /// </summary>
    public string FormName { get; set; }

    /// <summary>
    /// Gets or Sets ScoringSet
    /// </summary>
    public EvaluationQualityV2TopicEvaluationScoringSet ScoringSet { get; set; }

    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets AgentHasRead
    /// </summary>
    public bool? AgentHasRead { get; set; }

    /// <summary>
    /// Gets or Sets ReleaseDate
    /// </summary>
    public DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// Gets or Sets AssignedDate
    /// </summary>
    public DateTime? AssignedDate { get; set; }

    /// <summary>
    /// Gets or Sets ChangedDate
    /// </summary>
    public DateTime? ChangedDate { get; set; }

    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public string EventType { get; set; }

    /// <summary>
    /// Gets or Sets ResourceId
    /// </summary>
    public string ResourceId { get; set; }

    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    public string ResourceType { get; set; }

    /// <summary>
    /// Gets or Sets DivisionIds
    /// </summary>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// Gets or Sets Rescore
    /// </summary>
    public bool? Rescore { get; set; }

    /// <summary>
    /// Gets or Sets ConversationDate
    /// </summary>
    public DateTime? ConversationDate { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public IEnumerable<string> MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Calibration
    /// </summary>
    public EvaluationQualityV2TopicCalibration Calibration { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationSource
    /// </summary>
    public EvaluationQualityV2TopicEvaluationSource EvaluationSource { get; set; }

    /// <summary>
    /// Gets or Sets AssigneeUserId
    /// </summary>
    public string AssigneeUserId { get; set; }

    /// <summary>
    /// Gets or Sets PreviousAssigneeUserId
    /// </summary>
    public string PreviousAssigneeUserId { get; set; }

    /// <summary>
    /// Gets or Sets AssigneeApplicable
    /// </summary>
    public bool? AssigneeApplicable { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationContextId
    /// </summary>
    public string EvaluationContextId { get; set; }

    /// <summary>
    /// Gets or Sets DisputeCount
    /// </summary>
    public long? DisputeCount { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets DeclinedReview
    /// </summary>
    public bool? DeclinedReview { get; set; }

    /// <summary>
    /// Gets or Sets RetractedEvaluation
    /// </summary>
    public EvaluationQualityV2TopicEvaluationReference RetractedEvaluation { get; set; }

    /// <summary>
    /// Gets or Sets RescoreCount
    /// </summary>
    public long? RescoreCount { get; set; }

    /// <summary>
    /// Gets or Sets EvaluatorCommentHasUpdated
    /// </summary>
    public bool? EvaluatorCommentHasUpdated { get; set; }

    /// <summary>
    /// Gets or Sets AgentCommentHasUpdated
    /// </summary>
    public bool? AgentCommentHasUpdated { get; set; }

    /// <summary>
    /// Gets or Sets PreviousRescoreCount
    /// </summary>
    public long? PreviousRescoreCount { get; set; }

    /// <summary>
    /// Gets or Sets PreviousEvaluatorUserId
    /// </summary>
    public string PreviousEvaluatorUserId { get; set; }
}
