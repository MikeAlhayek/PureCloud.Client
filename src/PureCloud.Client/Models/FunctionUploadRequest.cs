using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FunctionUploadRequest
{
    /// <summary>
    /// Name of the file to upload.File name can only contain letters, numbers, and the following special characters: + - _ . &#39; ( )
    /// </summary>
    /// <value>Name of the file to upload.File name can only contain letters, numbers, and the following special characters: + - _ . &#39; ( )</value>
    public string FileName { get; set; }

    /// <summary>
    /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds
    /// </summary>
    /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds</value>
    public int? SignedUrlTimeoutSeconds { get; set; }
}
