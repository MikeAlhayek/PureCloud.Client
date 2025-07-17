using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDefinitionUpdateRequest
{
    /// <summary>
    /// The default objective type of the External Metric Definition
    /// </summary>
    /// <value>The default objective type of the External Metric Definition</value>
    public ExternalMetricDefinitionUpdateRequestDefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }

    /// <summary>
    /// The name of the External Metric Definition
    /// </summary>
    /// <value>The name of the External Metric Definition</value>
    public string Name { get; set; }

    /// <summary>
    /// The decimal precision of the External Metric Definition. Must be at least 0 and at most 5
    /// </summary>
    /// <value>The decimal precision of the External Metric Definition. Must be at least 0 and at most 5</value>
    public int? Precision { get; set; }

    /// <summary>
    /// True if the External Metric Definition is enabled
    /// </summary>
    /// <value>True if the External Metric Definition is enabled</value>
    public bool? Enabled { get; set; }
}
