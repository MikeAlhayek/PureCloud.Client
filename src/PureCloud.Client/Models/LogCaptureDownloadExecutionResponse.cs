using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LogCaptureDownloadExecutionResponse
{
    /// <summary>
    /// Execution state of the download.
    /// </summary>
    public LogCaptureDownloadExecutionResponseState? State { get; set; }

    /// <summary>
    /// Id of file download job.
    /// </summary>
    /// <value>Id of file download job.</value>
    public string Id { get; set; }

    /// <summary>
    /// Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Url of a file with query result.
    /// </summary>
    /// <value>Url of a file with query result.</value>
    public string FileUrl { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// Details of the user that created the job
    /// </summary>
    /// <value>Details of the user that created the job</value>
    public AddressableEntityRef User { get; set; }
}
