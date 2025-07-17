using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetricDefinition
{
    /// <summary>
    /// The type of associated metric unit
    /// </summary>
    /// <value>The type of associated metric unit</value>
    public MetricDefinitionUnitTypeEnum? UnitType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    public string Name { get; set; }

    /// <summary>
    /// An alternate name for this metric definition, often abbreviation
    /// </summary>
    /// <value>An alternate name for this metric definition, often abbreviation</value>
    public string ShortName { get; set; }

    /// <summary>
    /// Metric names used as dividend
    /// </summary>
    /// <value>Metric names used as dividend</value>
    public IEnumerable<string> DividendMetrics { get; set; }

    /// <summary>
    /// Metric names used as divisor
    /// </summary>
    /// <value>Metric names used as divisor</value>
    public IEnumerable<string> DivisorMetrics { get; set; }

    /// <summary>
    /// A predefined default objective for this metric
    /// </summary>
    /// <value>A predefined default objective for this metric</value>
    public DefaultObjective DefaultObjective { get; set; }

    /// <summary>
    /// An optional field to specify if this metric definition is locked to certain template. e.g. punctuality
    /// </summary>
    /// <value>An optional field to specify if this metric definition is locked to certain template. e.g. punctuality</value>
    public string LockTemplateId { get; set; }

    /// <summary>
    /// Flag to indicate if this metricDefinition allows filter based on media types
    /// </summary>
    /// <value>Flag to indicate if this metricDefinition allows filter based on media types</value>
    public bool? MediaTypeFilteringAllowed { get; set; }

    /// <summary>
    /// Flag to indicate if this metricDefinition allows filter based on initial direction
    /// </summary>
    /// <value>Flag to indicate if this metricDefinition allows filter based on initial direction</value>
    public bool? InitialDirectionFilteringAllowed { get; set; }

    /// <summary>
    /// Flag to indicate if this metricDefinition allows filter based on queues
    /// </summary>
    /// <value>Flag to indicate if this metricDefinition allows filter based on queues</value>
    public bool? QueueFilteringAllowed { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
