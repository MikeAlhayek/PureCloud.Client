using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition
{
    /// <summary>
    /// Gets or Sets Unit
    /// </summary>
    public EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinitionUnitEnum? Unit { get; set; }

    /// <summary>
    /// Gets or Sets DefaultObjectiveType
    /// </summary>
    public EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinitionDefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets UnitDefinition
    /// </summary>
    public string UnitDefinition { get; set; }

    /// <summary>
    /// Gets or Sets Precision
    /// </summary>
    public long? Precision { get; set; }

    /// <summary>
    /// Gets or Sets RetentionMonths
    /// </summary>
    public long? RetentionMonths { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets InUse
    /// </summary>
    public bool? InUse { get; set; }

    /// <summary>
    /// Gets or Sets DateLastRefreshed
    /// </summary>
    public DateTime? DateLastRefreshed { get; set; }
}
