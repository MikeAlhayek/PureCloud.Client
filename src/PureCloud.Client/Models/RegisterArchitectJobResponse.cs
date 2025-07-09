using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RegisterArchitectJobResponse
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Presigned URL to upload the file in S3
    /// </summary>
    /// <value>Presigned URL to upload the file in S3</value>
    public string PresignedUrl { get; set; }

    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    public Dictionary<string, string> Headers { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
