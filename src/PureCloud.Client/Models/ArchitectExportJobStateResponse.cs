using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectExportJobStateResponse
{
    /// <summary>
    /// Status of the Architect Export Job
    /// </summary>
    /// <value>Status of the Architect Export Job</value>
    public ArchitectExportJobStateResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The command executed by the Architect Job
    /// </summary>
    /// <value>The command executed by the Architect Job</value>
    public ArchitectExportJobStateResponseCommandEnum? Command { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows.
    /// </summary>
    /// <value>The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows.</value>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Warnings and Errors messages of the Architect Job
    /// </summary>
    /// <value>Warnings and Errors messages of the Architect Job</value>
    public IEnumerable<ArchitectJobMessage> Messages { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
