using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// UploadUrlRequest
/// </summary>
[DataContract]
public partial class UploadUrlRequest : IEquatable<UploadUrlRequest>
{
    /// <summary>
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Gets or Sets ServerSideEncryption
    /// </summary>
    [DataMember(Name = "serverSideEncryption", EmitDefaultValue = false)]
    public ServerSideEncryptionEnum? ServerSideEncryption { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UploadUrlRequest" /> class.
    /// </summary>
    /// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|.</param>
    /// <param name="ContentMd5">Content MD5 of the file to upload.</param>
    /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
    /// <param name="ContentType">The content type of the file to upload. Allows all MIME types.</param>
    /// <param name="ServerSideEncryption">ServerSideEncryption.</param>
    public UploadUrlRequest(string FileName = null, string ContentMd5 = null, int? SignedUrlTimeoutSeconds = null, string ContentType = null, ServerSideEncryptionEnum? ServerSideEncryption = null)
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
    [DataMember(Name = "fileName", EmitDefaultValue = false)]
    public string FileName { get; set; }



    /// <summary>
    /// Content MD5 of the file to upload
    /// </summary>
    /// <value>Content MD5 of the file to upload</value>
    [DataMember(Name = "contentMd5", EmitDefaultValue = false)]
    public string ContentMd5 { get; set; }



    /// <summary>
    /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
    /// </summary>
    /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
    [DataMember(Name = "signedUrlTimeoutSeconds", EmitDefaultValue = false)]
    public int? SignedUrlTimeoutSeconds { get; set; }



    /// <summary>
    /// The content type of the file to upload. Allows all MIME types
    /// </summary>
    /// <value>The content type of the file to upload. Allows all MIME types</value>
    [DataMember(Name = "contentType", EmitDefaultValue = false)]
    public string ContentType { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UploadUrlRequest {\n");

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
        return this.Equals(obj as UploadUrlRequest);
    }

    /// <summary>
    /// Returns true if UploadUrlRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UploadUrlRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UploadUrlRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.FileName == other.FileName ||
                this.FileName != null &&
                this.FileName.Equals(other.FileName)
            ) &&
            (
                this.ContentMd5 == other.ContentMd5 ||
                this.ContentMd5 != null &&
                this.ContentMd5.Equals(other.ContentMd5)
            ) &&
            (
                this.SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                this.SignedUrlTimeoutSeconds != null &&
                this.SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
            ) &&
            (
                this.ContentType == other.ContentType ||
                this.ContentType != null &&
                this.ContentType.Equals(other.ContentType)
            ) &&
            (
                this.ServerSideEncryption == other.ServerSideEncryption ||
                this.ServerSideEncryption != null &&
                this.ServerSideEncryption.Equals(other.ServerSideEncryption)
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
            if (this.FileName != null)
            {
                hash = hash * 59 + this.FileName.GetHashCode();
            }

            if (this.ContentMd5 != null)
            {
                hash = hash * 59 + this.ContentMd5.GetHashCode();
            }

            if (this.SignedUrlTimeoutSeconds != null)
            {
                hash = hash * 59 + this.SignedUrlTimeoutSeconds.GetHashCode();
            }

            if (this.ContentType != null)
            {
                hash = hash * 59 + this.ContentType.GetHashCode();
            }

            if (this.ServerSideEncryption != null)
            {
                hash = hash * 59 + this.ServerSideEncryption.GetHashCode();
            }

            return hash;
        }
    }
}
