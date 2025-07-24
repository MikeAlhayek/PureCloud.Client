using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// CalibrationCreate
/// </summary>
public sealed class CalibrationCreate
{
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
    /// Gets or Sets Calibrator
    /// </summary>
    public User Calibrator { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public User Agent { get; set; }

    /// <summary>
    /// The conversation to use for the calibration.
    /// </summary>
    /// <value>The conversation to use for the calibration.</value>
    public ConversationReference Conversation { get; set; }

    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    public EvaluationForm EvaluationForm { get; set; }

    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets AverageScore
    /// </summary>
    public int? AverageScore { get; set; }

    /// <summary>
    /// Gets or Sets HighScore
    /// </summary>
    public int? HighScore { get; set; }

    /// <summary>
    /// Gets or Sets LowScore
    /// </summary>
    public int? LowScore { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets Evaluations
    /// </summary>
    public IEnumerable<Evaluation> Evaluations { get; set; }

    /// <summary>
    /// Gets or Sets Evaluators
    /// </summary>
    public IEnumerable<User> Evaluators { get; set; }

    /// <summary>
    /// Gets or Sets ScoringIndex
    /// </summary>
    public Evaluation ScoringIndex { get; set; }

    /// <summary>
    /// Gets or Sets ExpertEvaluator
    /// </summary>
    public User ExpertEvaluator { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
