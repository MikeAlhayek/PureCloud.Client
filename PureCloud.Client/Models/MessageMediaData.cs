using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageMediaData
/// </summary>

public partial class MessageMediaData : IEquatable<MessageMediaData>
{
    /// <summary>
    /// The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid
    /// </summary>
    /// <value>The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid</value>
    
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
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Valid for "valid"
        /// </summary>
        [EnumMember(Value = "valid")]
        Valid,

        /// <summary>
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid
    }
    /// <summary>
    /// The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid
    /// </summary>
    /// <value>The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageMediaData" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Url">The location of the media, useful for retrieving it.</param>
    /// <param name="MediaType">The detected internet media type of the the media object.  If null then the media type should be dictated by the url..</param>
    /// <param name="ContentLengthBytes">The optional content length of the the media object, in bytes..</param>
    /// <param name="UploadUrl">The URL returned to upload an attachment.</param>
    public MessageMediaData(string Name = null, string Url = null, string MediaType = null, int? ContentLengthBytes = null, string UploadUrl = null)
    {
        this.Name = Name;
        this.Url = Url;
        this.MediaType = MediaType;
        this.ContentLengthBytes = ContentLengthBytes;
        this.UploadUrl = UploadUrl;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The location of the media, useful for retrieving it
    /// </summary>
    /// <value>The location of the media, useful for retrieving it</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// The detected internet media type of the the media object.  If null then the media type should be dictated by the url.
    /// </summary>
    /// <value>The detected internet media type of the the media object.  If null then the media type should be dictated by the url.</value>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; }



    /// <summary>
    /// The optional content length of the the media object, in bytes.
    /// </summary>
    /// <value>The optional content length of the the media object, in bytes.</value>
    [JsonPropertyName("contentLengthBytes")]
    public int? ContentLengthBytes { get; set; }



    /// <summary>
    /// The URL returned to upload an attachment
    /// </summary>
    /// <value>The URL returned to upload an attachment</value>
    [JsonPropertyName("uploadUrl")]
    public string UploadUrl { get; set; }





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
        sb.Append("class MessageMediaData {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
        sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as MessageMediaData);
    }

    /// <summary>
    /// Returns true if MessageMediaData instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageMediaData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageMediaData other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ContentLengthBytes == other.ContentLengthBytes ||
                ContentLengthBytes != null &&
                ContentLengthBytes.Equals(other.ContentLengthBytes)
            ) &&
            (
                UploadUrl == other.UploadUrl ||
                UploadUrl != null &&
                UploadUrl.Equals(other.UploadUrl)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ContentLengthBytes != null)
            {
                hash = hash * 59 + ContentLengthBytes.GetHashCode();
            }

            if (UploadUrl != null)
            {
                hash = hash * 59 + UploadUrl.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
