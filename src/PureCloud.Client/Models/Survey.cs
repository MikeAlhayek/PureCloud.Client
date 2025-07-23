using PureCloud.Client.Models.Teams;

namespace PureCloud.Client.Models;

/// <summary>
/// Survey
/// </summary>
public sealed class Survey
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
    /// Gets or Sets Conversation
    /// </summary>
    public ConversationReference Conversation { get; set; }

    /// <summary>
    /// Survey form used for this survey.
    /// </summary>
    /// <value>Survey form used for this survey.</value>
    public SurveyForm SurveyForm { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    public DomainEntityRef Agent { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public SurveyStatus? Status { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public QueueReference Queue { get; set; }

    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    public SurveyScoringSet Answers { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CompletedDate { get; set; }

    /// <summary>
    /// Additional information about what happened when the survey is in Error status.
    /// </summary>
    /// <value>Additional information about what happened when the survey is in Error status.</value>
    public SurveyErrorDetails SurveyErrorDetails { get; set; }

    /// <summary>
    /// The team that the agent belongs to
    /// </summary>
    /// <value>The team that the agent belongs to</value>
    public Team AgentTeam { get; set; }

    /// <summary>
    /// Type of the survey
    /// </summary>
    /// <value>Type of the survey</value>
    public SurveyType? SurveyType { get; set; }

    /// <summary>
    /// True if any of the required questions for the survey form have not been answered. Null if survey is not finished.
    /// </summary>
    /// <value>True if any of the required questions for the survey form have not been answered. Null if survey is not finished.</value>
    public bool? MissingRequiredAnswer { get; set; }

    /// <summary>
    /// An Architect flow that executed in order to collect the answers for this survey.
    /// </summary>
    /// <value>An Architect flow that executed in order to collect the answers for this survey.</value>
    public AddressableEntityRef Flow { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}