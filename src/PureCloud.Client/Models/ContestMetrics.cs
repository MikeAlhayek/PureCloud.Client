using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestMetrics
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
    /// The Contest Metrics weight, allowed values are 1-100
    /// </summary>
    /// <value>The Contest Metrics weight, allowed values are 1-100</value>
    public int? Weight { get; set; }

    /// <summary>
    /// The Contest Metrics minimum qualifier. Min value is 0, no Max value
    /// </summary>
    /// <value>The Contest Metrics minimum qualifier. Min value is 0, no Max value</value>
    public int? MinimumQualifier { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
