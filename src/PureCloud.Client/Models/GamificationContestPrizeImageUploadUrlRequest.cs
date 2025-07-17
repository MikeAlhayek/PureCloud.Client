using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GamificationContestPrizeImageUploadUrlRequest
{
    /// <summary>
    /// The content type of the file to upload.
    /// </summary>
    /// <value>The content type of the file to upload.</value>
    public GamificationContestPrizeImageUploadUrlRequestContentTypeEnum? ContentType { get; set; }

    /// <summary>
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    public GamificationContestPrizeImageUploadUrlRequestServerSideEncryptionEnum? ServerSideEncryption { get; set; }

    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
    public string FileName { get; set; }

    /// <summary>
    /// Content MD5 of the file to upload
    /// </summary>
    /// <value>Content MD5 of the file to upload</value>
    public string ContentMd5 { get; set; }

    /// <summary>
    /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
    /// </summary>
    /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
    public int? SignedUrlTimeoutSeconds { get; set; }

    /// <summary>
    /// The size of the file to upload.
    /// </summary>
    /// <value>The size of the file to upload.</value>
    public long? ContentLength { get; set; }
}
