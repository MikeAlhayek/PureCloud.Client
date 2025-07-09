using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExecutionDataEntity
{
    /// <summary>
    /// The id of the execution requested
    /// </summary>
    /// <value>The id of the execution requested</value>
    public string Id { get; set; }

    /// <summary>
    /// A downloadable link to the execution data file.
    /// </summary>
    /// <value>A downloadable link to the execution data file.</value>
    public string DownloadUri { get; set; }

    /// <summary>
    /// If the retrieval failed (not found, no permission, etc;), this will be set true.
    /// </summary>
    /// <value>If the retrieval failed (not found, no permission, etc;), this will be set true.</value>
    public bool? Failed { get; set; }

    /// <summary>
    /// This will contain the http status code for the failure
    /// </summary>
    /// <value>This will contain the http status code for the failure</value>
    public string StatusCode { get; set; }
}
