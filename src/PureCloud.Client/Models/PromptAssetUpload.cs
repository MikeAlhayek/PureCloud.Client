using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PromptAssetUpload
{
    /// <summary>
    /// Pre-signed URL to PUT the file to
    /// </summary>
    /// <value>Pre-signed URL to PUT the file to</value>
    public string Url { get; set; }

    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    public Dictionary<string, string> Headers { get; set; }
}
