using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DataTableImportJob
{
    /// <summary>
    /// The status of the import job
    /// </summary>
    /// <value>The status of the import job</value>
    public DataTableImportJobStatusEnum? Status { get; set; }

    /// <summary>
    /// The indication of whether the processing should remove rows that don't appear in the import file
    /// </summary>
    /// <value>The indication of whether the processing should remove rows that don't appear in the import file</value>
    public DataTableImportJobImportModeEnum? ImportMode { get; set; }

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
    /// The PureCloudEnvironment user who started the import job
    /// </summary>
    /// <value>The PureCloudEnvironment user who started the import job</value>
    public AddressableEntityRef Owner { get; set; }

    /// <summary>
    /// The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// The URL of the location at which the caller can upload the file to be imported
    /// </summary>
    /// <value>The URL of the location at which the caller can upload the file to be imported</value>
    public string UploadURI { get; set; }

    /// <summary>
    /// Any error information, or null of the processing is not in an error state
    /// </summary>
    /// <value>Any error information, or null of the processing is not in an error state</value>
    public ErrorBody ErrorInformation { get; set; }

    /// <summary>
    /// The current count of the number of records processed
    /// </summary>
    /// <value>The current count of the number of records processed</value>
    public int? CountRecordsUpdated { get; set; }

    /// <summary>
    /// The current count of the number of records deleted
    /// </summary>
    /// <value>The current count of the number of records deleted</value>
    public int? CountRecordsDeleted { get; set; }

    /// <summary>
    /// The current count of the number of records that failed to import
    /// </summary>
    /// <value>The current count of the number of records that failed to import</value>
    public int? CountRecordsFailed { get; set; }

    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL in the &#39;uploadURI&#39; field
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL in the &#39;uploadURI&#39; field</value>
    public Dictionary<string, string> UploadHeaders { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
