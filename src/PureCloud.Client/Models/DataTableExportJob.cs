using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DataTableExportJob
{
    /// <summary>
    /// The status of the export job
    /// </summary>
    /// <value>The status of the export job</value>
    public DataTableExportJobStatusEnum? Status { get; set; }

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
    /// The PureCloudEnvironment user who started the export job
    /// </summary>
    /// <value>The PureCloudEnvironment user who started the export job</value>
    public AddressableEntityRef Owner { get; set; }

    /// <summary>
    /// The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// The URL of the location at which the caller can download the export file, when available
    /// </summary>
    /// <value>The URL of the location at which the caller can download the export file, when available</value>
    public string DownloadURI { get; set; }

    /// <summary>
    /// Any error information, or null of the processing is not in an error state
    /// </summary>
    /// <value>Any error information, or null of the processing is not in an error state</value>
    public ErrorBody ErrorInformation { get; set; }

    /// <summary>
    /// The current count of the number of records processed
    /// </summary>
    /// <value>The current count of the number of records processed</value>
    public int? CountRecordsProcessed { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
