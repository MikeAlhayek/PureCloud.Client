using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RegisterArchitectExportJobResponse
{
    /// <summary>
    /// The status of the export job.
    /// </summary>
    /// <value>The status of the export job.</value>
    public RegisterArchitectExportJobResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The number of flows submitted for export.
    /// </summary>
    /// <value>The number of flows submitted for export.</value>
    public int? TotalFlows { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
