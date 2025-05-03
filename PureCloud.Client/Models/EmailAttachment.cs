using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailAttachment
/// </summary>

public partial class EmailAttachment : IEquatable<EmailAttachment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAttachment" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ContentPath">ContentPath.</param>
    /// <param name="ContentType">ContentType.</param>
    /// <param name="AttachmentId">AttachmentId.</param>
    /// <param name="ContentLength">ContentLength.</param>
    public EmailAttachment(string Name = null, string ContentPath = null, string ContentType = null, string AttachmentId = null, int? ContentLength = null)
    {
        this.Name = Name;
        this.ContentPath = ContentPath;
        this.ContentType = ContentType;
        this.AttachmentId = AttachmentId;
        this.ContentLength = ContentLength;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ContentPath
    /// </summary>
    [JsonPropertyName("contentPath")]
    public string ContentPath { get; set; }



    /// <summary>
    /// Gets or Sets ContentType
    /// </summary>
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; }



    /// <summary>
    /// Gets or Sets AttachmentId
    /// </summary>
    [JsonPropertyName("attachmentId")]
    public string AttachmentId { get; set; }



    /// <summary>
    /// Gets or Sets ContentLength
    /// </summary>
    [JsonPropertyName("contentLength")]
    public int? ContentLength { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailAttachment {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ContentPath: ").Append(ContentPath).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
        sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
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
        return Equals(obj as EmailAttachment);
    }

    /// <summary>
    /// Returns true if EmailAttachment instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailAttachment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailAttachment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ContentPath == other.ContentPath ||
                ContentPath != null &&
                ContentPath.Equals(other.ContentPath)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                AttachmentId == other.AttachmentId ||
                AttachmentId != null &&
                AttachmentId.Equals(other.AttachmentId)
            ) &&
            (
                ContentLength == other.ContentLength ||
                ContentLength != null &&
                ContentLength.Equals(other.ContentLength)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ContentPath != null)
            {
                hash = hash * 59 + ContentPath.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (AttachmentId != null)
            {
                hash = hash * 59 + AttachmentId.GetHashCode();
            }

            if (ContentLength != null)
            {
                hash = hash * 59 + ContentLength.GetHashCode();
            }

            return hash;
        }
    }
}
