using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDefinition
{
    /// <summary>
    /// The unit of the External Metric Definition
    /// </summary>
    /// <value>The unit of the External Metric Definition</value>
    public ExternalMetricDefinitionUnitEnum? Unit { get; set; }

    /// <summary>
    /// The default objective type of the External Metric Definition
    /// </summary>
    /// <value>The default objective type of the External Metric Definition</value>
    public ExternalMetricDefinitionDefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

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
    /// The decimal precision of the External Metric Definition
    /// </summary>
    public int? Precision { get; set; }

    /// <summary>
    /// The retention in months of the External Metric Definition
    /// </summary>
    /// <value>The retention in months of the External Metric Definition</value>
    public int? RetentionMonths { get; set; }

    /// <summary>
    /// True if the External Metric Definition is enabled
    /// </summary>
    /// <value>True if the External Metric Definition is enabled</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// True if the External Metric Definition is in use
    /// </summary>
    public bool? InUse { get; set; }

    /// <summary>
    /// The last date and time that the metric data was refreshed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last date and time that the metric data was refreshed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastRefreshed { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
