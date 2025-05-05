using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentContentUpload
/// </summary>

public partial class KnowledgeDocumentContentUpload : IEquatable<KnowledgeDocumentContentUpload>
{
    /// <summary>
    /// Type of Article Content.
    /// </summary>
    /// <value>Type of Article Content.</value>
    
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
        /// Enum Body for "Body"
        /// </summary>
        [EnumMember(Value = "Body")]
        Body,

        /// <summary>
        /// Enum Attachment for "Attachment"
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment
    }
    /// <summary>
    /// Status of the upload operation
    /// </summary>
    /// <value>Status of the upload operation</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Validationfailed for "ValidationFailed"
        /// </summary>
        [EnumMember(Value = "ValidationFailed")]
        Validationfailed,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed
    }
    /// <summary>
    /// Type of Article Content.
    /// </summary>
    /// <value>Type of Article Content.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }
    /// <summary>
    /// Status of the upload operation
    /// </summary>
    /// <value>Status of the upload operation</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentContentUpload" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentContentUpload() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentContentUpload" /> class.
    /// </summary>
    /// <param name="ContentType">Type of Article Content. (required).</param>
    /// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| (required).</param>
    public KnowledgeDocumentContentUpload(ContentTypeEnum? ContentType = null, string FileName = null)
    {
        this.ContentType = ContentType;
        this.FileName = FileName;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }





    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }





    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    /// <value>Key that identifies the file in the storage including the file name</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; private set; }



    /// <summary>
    /// Presigned URL to PUT the file to
    /// </summary>
    /// <value>Presigned URL to PUT the file to</value>
    [JsonPropertyName("url")]
    public string Url { get; private set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; private set; }



    /// <summary>
    /// ID of the document for which article content is to be uploaded
    /// </summary>
    /// <value>ID of the document for which article content is to be uploaded</value>
    [JsonPropertyName("document")]
    public AddressableEntityRef Document { get; private set; }



    /// <summary>
    /// Error message when upload fails
    /// </summary>
    /// <value>Error message when upload fails</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentContentUpload {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeDocumentContentUpload);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentContentUpload instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentContentUpload to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentContentUpload other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
