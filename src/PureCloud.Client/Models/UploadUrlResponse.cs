using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UploadUrlResponse
{
    /// <summary>
    /// Presigned URL to PUT the file to
    /// </summary>
    /// <value>Presigned URL to PUT the file to</value>
    public string Url { get; set; }

    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    /// <value>Key that identifies the file in the storage including the file name</value>
    public string UploadKey { get; set; }

    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    public Dictionary<string, string> Headers { get; set; }
}
