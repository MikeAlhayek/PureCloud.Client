using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Metric
{
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    public MetricTimeDisplayUnitEnum? TimeDisplayUnit { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of this metric
    /// </summary>
    /// <value>The name of this metric</value>
    public string Name { get; set; }

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
    /// Associated objective for this metric
    /// </summary>
    /// <value>Associated objective for this metric</value>
    public Objective Objective { get; set; }

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
    /// The precision of the metric, must be between 0 and 5
    /// </summary>
    /// <value>The precision of the metric, must be between 0 and 5</value>
    public int? Precision { get; set; }

    /// <summary>
    /// The source performance profile when this metric is linked
    /// </summary>
    /// <value>The source performance profile when this metric is linked</value>
    public PerformanceProfile SourcePerformanceProfile { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
