namespace PureCloud.Client.Models;

/// <summary>
/// AiScoringSettings
/// </summary>

public sealed class AiScoringSettings
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets QuestionGroupSettings
    /// </summary>
    public IEnumerable<QuestionGroupSettings> QuestionGroupSettings { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
