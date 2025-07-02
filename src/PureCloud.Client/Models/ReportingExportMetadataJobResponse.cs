using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingExportMetadataJobResponse
{
    public ReportingExportMetadataJobResponseViewTypeEnum? ViewType { get; set; }

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
    /// The date limitations of the export metadata
    /// </summary>
    /// <value>The date limitations of the export metadata</value>
    public string DateLimitations { get; set; }

    /// <summary>
    /// The list of required filters for the export metadata
    /// </summary>
    /// <value>The list of required filters for the export metadata</value>
    public IEnumerable<string> RequiredFilters { get; set; }

    /// <summary>
    /// The list of supported filters for the export metadata
    /// </summary>
    /// <value>The list of supported filters for the export metadata</value>
    public IEnumerable<string> SupportedFilters { get; set; }

    /// <summary>
    /// The list of required column ids for the export metadata
    /// </summary>
    /// <value>The list of required column ids for the export metadata</value>
    public IEnumerable<string> RequiredColumnIds { get; set; }

    /// <summary>
    /// The list of dependent column ids for the export metadata
    /// </summary>
    /// <value>The list of dependent column ids for the export metadata</value>
    public Dictionary<string, List<string>> DependentColumnIds { get; set; }

    /// <summary>
    /// The list of available column ids for the export metadata
    /// </summary>
    /// <value>The list of available column ids for the export metadata</value>
    public IEnumerable<string> AvailableColumnIds { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
