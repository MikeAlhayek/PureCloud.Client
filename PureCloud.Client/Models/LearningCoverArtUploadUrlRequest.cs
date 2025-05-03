using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningCoverArtUploadUrlRequest
/// </summary>

public partial class LearningCoverArtUploadUrlRequest : IEquatable<LearningCoverArtUploadUrlRequest>
{
    /// <summary>
    /// The content type of the file to upload.
    /// </summary>
    /// <value>The content type of the file to upload.</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bmp for "image/bmp"
        /// </summary>
        [EnumMember(Value = "image/bmp")]
        Bmp,

        /// <summary>
        /// Enum Gif for "image/gif"
        /// </summary>
        [EnumMember(Value = "image/gif")]
        Gif,

        /// <summary>
        /// Enum Jpeg for "image/jpeg"
        /// </summary>
        [EnumMember(Value = "image/jpeg")]
        Jpeg,

        /// <summary>
        /// Enum Jpg for "image/jpg"
        /// </summary>
        [EnumMember(Value = "image/jpg")]
        Jpg,

        /// <summary>
        /// Enum Png for "image/png"
        /// </summary>
        [EnumMember(Value = "image/png")]
        Png
    }
    /// <summary>
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    
    public enum ServerSideEncryptionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Aes256 for "AES256"
        /// </summary>
        [EnumMember(Value = "AES256")]
        Aes256
    }
    /// <summary>
    /// The content type of the file to upload.
    /// </summary>
    /// <value>The content type of the file to upload.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }
    /// <summary>
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    [JsonPropertyName("serverSideEncryption")]
    public ServerSideEncryptionEnum? ServerSideEncryption { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningCoverArtUploadUrlRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningCoverArtUploadUrlRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningCoverArtUploadUrlRequest" /> class.
    /// </summary>
    /// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|.</param>
    /// <param name="ContentMd5">Content MD5 of the file to upload.</param>
    /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
    /// <param name="ContentType">The content type of the file to upload. (required).</param>
    /// <param name="ServerSideEncryption">ServerSideEncryption.</param>
    public LearningCoverArtUploadUrlRequest(string FileName = null, string ContentMd5 = null, int? SignedUrlTimeoutSeconds = null, ContentTypeEnum? ContentType = null, ServerSideEncryptionEnum? ServerSideEncryption = null)
    {
        this.FileName = FileName;
        this.ContentMd5 = ContentMd5;
        this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
        this.ContentType = ContentType;
        this.ServerSideEncryption = ServerSideEncryption;

    }



    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }



    /// <summary>
    /// Content MD5 of the file to upload
    /// </summary>
    /// <value>Content MD5 of the file to upload</value>
    [JsonPropertyName("contentMd5")]
    public string ContentMd5 { get; set; }



    /// <summary>
    /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
    /// </summary>
    /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
    [JsonPropertyName("signedUrlTimeoutSeconds")]
    public int? SignedUrlTimeoutSeconds { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningCoverArtUploadUrlRequest {\n");

        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
        sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  ServerSideEncryption: ").Append(ServerSideEncryption).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as LearningCoverArtUploadUrlRequest);
    }

    /// <summary>
    /// Returns true if LearningCoverArtUploadUrlRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningCoverArtUploadUrlRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningCoverArtUploadUrlRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                ContentMd5 == other.ContentMd5 ||
                ContentMd5 != null &&
                ContentMd5.Equals(other.ContentMd5)
            ) &&
            (
                SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                SignedUrlTimeoutSeconds != null &&
                SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                ServerSideEncryption == other.ServerSideEncryption ||
                ServerSideEncryption != null &&
                ServerSideEncryption.Equals(other.ServerSideEncryption)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (ContentMd5 != null)
            {
                hash = hash * 59 + ContentMd5.GetHashCode();
            }

            if (SignedUrlTimeoutSeconds != null)
            {
                hash = hash * 59 + SignedUrlTimeoutSeconds.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (ServerSideEncryption != null)
            {
                hash = hash * 59 + ServerSideEncryption.GetHashCode();
            }

            return hash;
        }
    }
}
