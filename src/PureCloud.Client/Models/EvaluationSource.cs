namespace PureCloud.Client.Models;

public sealed class EvaluationSource
{
    /// <summary>
    /// Type of the evaluation source.
    /// </summary>
    /// <value>Type of the evaluation source.</value>
    public EvaluationSourceType? Type { get; set; }

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
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
