using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicAttachment
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicAttachment : IEquatable<QueueConversationVideoEventTopicAttachment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicAttachment" /> class.
    /// </summary>
    /// <param name="AttachmentId">The unique identifier for the attachment..</param>
    /// <param name="Name">The name of the attachment..</param>
    /// <param name="ContentUri">The content uri of the attachment. If set, this is commonly a public api download location..</param>
    /// <param name="ContentType">The type of file the attachment is..</param>
    /// <param name="ContentLength">The length of the attachment file..</param>
    public QueueConversationVideoEventTopicAttachment(string AttachmentId = null, string Name = null, string ContentUri = null, string ContentType = null, long? ContentLength = null)
    {
        this.AttachmentId = AttachmentId;
        this.Name = Name;
        this.ContentUri = ContentUri;
        this.ContentType = ContentType;
        this.ContentLength = ContentLength;

    }



    /// <summary>
    /// The unique identifier for the attachment.
    /// </summary>
    /// <value>The unique identifier for the attachment.</value>
    [DataMember(Name = "attachmentId", EmitDefaultValue = false)]
    public string AttachmentId { get; set; }



    /// <summary>
    /// The name of the attachment.
    /// </summary>
    /// <value>The name of the attachment.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The content uri of the attachment. If set, this is commonly a public api download location.
    /// </summary>
    /// <value>The content uri of the attachment. If set, this is commonly a public api download location.</value>
    [DataMember(Name = "contentUri", EmitDefaultValue = false)]
    public string ContentUri { get; set; }



    /// <summary>
    /// The type of file the attachment is.
    /// </summary>
    /// <value>The type of file the attachment is.</value>
    [DataMember(Name = "contentType", EmitDefaultValue = false)]
    public string ContentType { get; set; }



    /// <summary>
    /// The length of the attachment file.
    /// </summary>
    /// <value>The length of the attachment file.</value>
    [DataMember(Name = "contentLength", EmitDefaultValue = false)]
    public long? ContentLength { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicAttachment {\n");

        sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicAttachment);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicAttachment instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicAttachment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicAttachment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AttachmentId == other.AttachmentId ||
                AttachmentId != null &&
                AttachmentId.Equals(other.AttachmentId)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ContentUri == other.ContentUri ||
                ContentUri != null &&
                ContentUri.Equals(other.ContentUri)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
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
            if (AttachmentId != null)
            {
                hash = hash * 59 + AttachmentId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ContentUri != null)
            {
                hash = hash * 59 + ContentUri.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (ContentLength != null)
            {
                hash = hash * 59 + ContentLength.GetHashCode();
            }

            return hash;
        }
    }
}
