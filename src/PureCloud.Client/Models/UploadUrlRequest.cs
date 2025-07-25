namespace PureCloud.Client.Models;

public sealed class UploadUrlRequest
{
    /// <summary>
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    public UploadUrlRequestServerSideEncryptionEnum? ServerSideEncryption { get; set; }

    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Content MD5 of the file to upload
    /// </summary>
    public string ContentMd5 { get; set; }

    /// <summary>
    /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
    /// </summary>
    public int? SignedUrlTimeoutSeconds { get; set; }

    /// <summary>
    /// The content type of the file to upload. Allows all MIME types
    /// </summary>
    public string ContentType { get; set; }
}
