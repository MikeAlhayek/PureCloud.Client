using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Metrics
{
    /// <summary>
    /// Corresponding unit type for this metric
    /// </summary>
    /// <value>Corresponding unit type for this metric</value>
    public MetricsUnitTypeEnum? UnitType { get; set; }

    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    public MetricsTimeDisplayUnitEnum? TimeDisplayUnit { get; set; }

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
    /// The order of metric within a performance profile
    /// </summary>
    /// <value>The order of metric within a performance profile</value>
    public int? Order { get; set; }

    /// <summary>
    /// The name of associated metric definition
    /// </summary>
    /// <value>The name of associated metric definition</value>
    public string MetricDefinitionName { get; set; }

    /// <summary>
    /// The id of associated metric definition
    /// </summary>
    /// <value>The id of associated metric definition</value>
    public string MetricDefinitionId { get; set; }

    /// <summary>
    /// The id of associated external metric definition
    /// </summary>
    /// <value>The id of associated external metric definition</value>
    public string ExternalMetricDefinitionId { get; set; }

    /// <summary>
    /// A flag for whether this metric is enabled for a performance profile
    /// </summary>
    /// <value>A flag for whether this metric is enabled for a performance profile</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The name of associated objective template
    /// </summary>
    /// <value>The name of associated objective template</value>
    public string TemplateName { get; set; }

    /// <summary>
    /// Achievable maximum points for this metric
    /// </summary>
    /// <value>Achievable maximum points for this metric</value>
    public int? MaxPoints { get; set; }

    /// <summary>
    /// Performance profile id of this metric
    /// </summary>
    /// <value>Performance profile id of this metric</value>
    public string PerformanceProfileId { get; set; }

    /// <summary>
    /// The linked metric entity reference
    /// </summary>
    /// <value>The linked metric entity reference</value>
    public AddressableEntityRef LinkedMetric { get; set; }

    /// <summary>
    /// The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateUnlinked { get; set; }

    /// <summary>
    /// The source performance profile when this metric is linked
    /// </summary>
    /// <value>The source performance profile when this metric is linked</value>
    public PerformanceProfile SourcePerformanceProfile { get; set; }

    /// <summary>
    /// Unit definition of linked external metric
    /// </summary>
    /// <value>Unit definition of linked external metric</value>
    public string UnitDefinition { get; set; }

    /// <summary>
    /// Precision of linked external metric
    /// </summary>
    /// <value>Precision of linked external metric</value>
    public int? Precision { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
