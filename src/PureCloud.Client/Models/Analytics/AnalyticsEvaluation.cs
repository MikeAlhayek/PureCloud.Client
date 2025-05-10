namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsEvaluation
{
    /// <summary>
    /// Status of evaluation
    /// </summary>
    /// <value>Status of evaluation</value>
    public AnalyticsEvaluationEvaluationStatus? EvaluationStatus { get; set; }

    /// <summary>
    /// Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable
    /// </summary>
    /// <value>Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable</value>
    public bool? AssigneeApplicable { get; set; }

    /// <summary>
    /// UserId of the assignee
    /// </summary>
    /// <value>UserId of the assignee</value>
    public string AssigneeId { get; set; }

    /// <summary>
    /// The calibration ID used for the purpose of training evaluators
    /// </summary>
    /// <value>The calibration ID used for the purpose of training evaluators</value>
    public string CalibrationId { get; set; }

    /// <summary>
    /// A unique identifier for an evaluation form, regardless of version
    /// </summary>
    /// <value>A unique identifier for an evaluation form, regardless of version</value>
    public string ContextId { get; set; }

    /// <summary>
    /// Whether the evaluation has been deleted
    /// </summary>
    /// <value>Whether the evaluation has been deleted</value>
    public bool? Deleted { get; set; }

    /// <summary>
    /// Unique identifier for the evaluation
    /// </summary>
    /// <value>Unique identifier for the evaluation</value>
    public string EvaluationId { get; set; }

    /// <summary>
    /// A unique identifier of the user who evaluated the interaction
    /// </summary>
    /// <value>A unique identifier of the user who evaluated the interaction</value>
    public string EvaluatorId { get; set; }

    /// <summary>
    /// Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// ID of the evaluation form used
    /// </summary>
    /// <value>ID of the evaluation form used</value>
    public string FormId { get; set; }

    /// <summary>
    /// Name of the evaluation form used
    /// </summary>
    /// <value>Name of the evaluation form used</value>
    public string FormName { get; set; }

    /// <summary>
    /// The ID of the associated queue
    /// </summary>
    /// <value>The ID of the associated queue</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Whether the evaluation has been released
    /// </summary>
    /// <value>Whether the evaluation has been released</value>
    public bool? Released { get; set; }

    /// <summary>
    /// Whether the evaluation has been rescored at least once
    /// </summary>
    /// <value>Whether the evaluation has been rescored at least once</value>
    public bool? Rescored { get; set; }

    /// <summary>
    /// ID of the agent the evaluation was performed against
    /// </summary>
    /// <value>ID of the agent the evaluation was performed against</value>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets OTotalCriticalScore
    /// </summary>
    public long? OTotalCriticalScore { get; set; }

    /// <summary>
    /// Gets or Sets OTotalScore
    /// </summary>
    public long? OTotalScore { get; set; }
}
