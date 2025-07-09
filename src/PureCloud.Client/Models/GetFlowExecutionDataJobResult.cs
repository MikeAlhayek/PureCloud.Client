using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GetFlowExecutionDataJobResult
{
    /// <summary>
    /// The state of the backend process to prep the files for download.
    /// </summary>
    /// <value>The state of the backend process to prep the files for download.</value>
    public GetFlowExecutionDataJobResultJobStateEnum? JobState { get; set; }

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
    /// On jobState &#x3D; Success this field will be populated with the list of results of files for download.
    /// </summary>
    /// <value>On jobState &#x3D; Success this field will be populated with the list of results of files for download.</value>
    public IEnumerable<ExecutionDataEntity> Entities { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
