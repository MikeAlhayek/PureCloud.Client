using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateResponseAssetResponse
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Pre-signed URL to PUT the file to
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    public Dictionary<string, string> Headers { get; set; }
}
