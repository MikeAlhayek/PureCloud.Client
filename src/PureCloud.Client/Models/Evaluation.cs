using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Teams;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Evaluation
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public EvaluationStatus? Status { get; set; }

    /// <summary>
    /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
    /// </summary>
    /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
    public EvaluationResourceType? ResourceType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    public ConversationReference Conversation { get; set; }

    /// <summary>
    /// Evaluation form used for evaluation.
    /// </summary>
    /// <value>Evaluation form used for evaluation.</value>
    public EvaluationForm EvaluationForm { get; set; }

    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    public User Evaluator { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public User Agent { get; set; }

    /// <summary>
    /// Gets or Sets Calibration
    /// </summary>
    public Calibration Calibration { get; set; }

    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    public EvaluationScoringSet Answers { get; set; }

    /// <summary>
    /// Gets or Sets AgentHasRead
    /// </summary>
    public bool? AgentHasRead { get; set; }

    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    public User Assignee { get; set; }

    /// <summary>
    /// Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.
    /// </summary>
    /// <value>Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.</value>
    public bool? AssigneeApplicable { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? AssignedDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ChangedDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? RevisionCreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public Queue Queue { get; set; }

    /// <summary>
    /// List of different communication types used in conversation.
    /// </summary>
    /// <value>List of different communication types used in conversation.</value>
    public IEnumerable<EvaluationMediaType> MediaType { get; set; }

    /// <summary>
    /// Is only true when evaluation is re-scored.
    /// </summary>
    /// <value>Is only true when evaluation is re-scored.</value>
    public bool? Rescore { get; set; }

    /// <summary>
    /// Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationDate { get; set; }

    /// <summary>
    /// End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ConversationEndDate { get; set; }

    /// <summary>
    /// Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.
    /// </summary>
    /// <value>Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.</value>
    public bool? NeverRelease { get; set; }

    /// <summary>
    /// Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.
    /// </summary>
    /// <value>Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.</value>
    public bool? Assigned { get; set; }

    /// <summary>
    /// Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateAssigneeChanged { get; set; }

    /// <summary>
    /// Only used for email evaluations. Will be null for all other evaluations.
    /// </summary>
    /// <value>Only used for email evaluations. Will be null for all other evaluations.</value>
    public string ResourceId { get; set; }

    /// <summary>
    /// Is only true when the user making the request does not have sufficient permissions to see evaluation
    /// </summary>
    /// <value>Is only true when the user making the request does not have sufficient permissions to see evaluation</value>
    public bool? Redacted { get; set; }

    /// <summary>
    /// Team of the evaluation agent
    /// </summary>
    /// <value>Team of the evaluation agent</value>
    public Team AgentTeam { get; set; }

    /// <summary>
    /// Gets or Sets IsScoringIndex
    /// </summary>
    public bool? IsScoringIndex { get; set; }

    /// <summary>
    /// List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit
    /// </summary>
    /// <value>List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit</value>
    public IEnumerable<string> AuthorizedActions { get; set; }

    /// <summary>
    /// Is true when evaluation assistance didn&#39;t execute successfully
    /// </summary>
    /// <value>Is true when evaluation assistance didn&#39;t execute successfully</value>
    public bool? HasAssistanceFailed { get; set; }

    /// <summary>
    /// The source that created the evaluation.
    /// </summary>
    /// <value>The source that created the evaluation.</value>
    public EvaluationSource EvaluationSource { get; set; }

    /// <summary>
    /// AI scoring details for the evaluation.
    /// </summary>
    /// <value>AI scoring details for the evaluation.</value>
    public AiScoring AiScoring { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
