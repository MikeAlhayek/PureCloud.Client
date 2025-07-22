using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FunctionZipConfig
{
    /// <summary>
    /// Status of zip upload.
    /// </summary>
    /// <value>Status of zip upload.</value>
    public FunctionZipConfigStatusEnum? Status { get; set; }

    /// <summary>
    /// Zip file Identifier
    /// </summary>
    /// <value>Zip file Identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// Zip file name
    /// </summary>
    /// <value>Zip file name</value>
    public string Name { get; set; }

    /// <summary>
    /// Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Error message if upload failed.
    /// </summary>
    /// <value>Error message if upload failed.</value>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Upload request id used for zip upload
    /// </summary>
    /// <value>Upload request id used for zip upload</value>
    public string RequestId { get; set; }
}
