using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDefinitionCreateRequest
{
    /// <summary>
    /// The unit of the External Metric Definition
    /// </summary>
    /// <value>The unit of the External Metric Definition</value>
    public ExternalMetricDefinitionCreateRequestUnitEnum? Unit { get; set; }

    /// <summary>
    /// The default objective type of the External Metric Definition
    /// </summary>
    /// <value>The default objective type of the External Metric Definition</value>
    public ExternalMetricDefinitionCreateRequestDefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }

    /// <summary>
    /// The name of the External Metric Definition
    /// </summary>
    /// <value>The name of the External Metric Definition</value>
    public string Name { get; set; }

    /// <summary>
    /// The unit definition of the External Metric Definition
    /// </summary>
    /// <value>The unit definition of the External Metric Definition</value>
    public string UnitDefinition { get; set; }

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
