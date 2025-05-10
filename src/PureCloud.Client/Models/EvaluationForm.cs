namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationForm
/// </summary>

public sealed class EvaluationForm
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The evaluation form name
    /// </summary>
    /// <value>The evaluation form name</value>
    public string Name { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    public bool? Published { get; set; }

    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    public string ContextId { get; set; }

    /// <summary>
    /// A list of question groups
    /// </summary>
    /// <value>A list of question groups</value>
    public IEnumerable<EvaluationQuestionGroup> QuestionGroups { get; set; }

    /// <summary>
    /// A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).
    /// </summary>
    /// <value>A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).</value>
    public PagedResource<EvaluationForm> PublishedVersions { get; set; }

    /// <summary>
    /// Settings for evaluations associated with this form
    /// </summary>
    /// <value>Settings for evaluations associated with this form</value>
    public EvaluationSettings EvaluationSettings { get; set; }

    /// <summary>
    /// AI scoring settings for the evaluation form.
    /// </summary>
    /// <value>AI scoring settings for the evaluation form.</value>
    public AiScoringSettings AiScoring { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
