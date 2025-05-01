using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicMessageMedia
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicMessageMedia : IEquatable<QueueConversationVideoEventTopicMessageMedia>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicMessageMedia" /> class.
    /// </summary>
    /// <param name="Url">The location of the media, useful for retrieving it.</param>
    /// <param name="MediaType">The optional internet media type of the the media object.  If null then the media type should be dictated by the url.</param>
    /// <param name="ContentLengthBytes">The optional content length of the the media object, in bytes..</param>
    /// <param name="Name">The optional name of the the media object..</param>
    /// <param name="Id">The optional id of the the media object..</param>
    public QueueConversationVideoEventTopicMessageMedia(string Url = null, string MediaType = null, long? ContentLengthBytes = null, string Name = null, string Id = null)
    {
        this.Url = Url;
        this.MediaType = MediaType;
        this.ContentLengthBytes = ContentLengthBytes;
        this.Name = Name;
        this.Id = Id;

    }



    /// <summary>
    /// The location of the media, useful for retrieving it
    /// </summary>
    /// <value>The location of the media, useful for retrieving it</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }



    /// <summary>
    /// The optional internet media type of the the media object.  If null then the media type should be dictated by the url
    /// </summary>
    /// <value>The optional internet media type of the the media object.  If null then the media type should be dictated by the url</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public string MediaType { get; set; }



    /// <summary>
    /// The optional content length of the the media object, in bytes.
    /// </summary>
    /// <value>The optional content length of the the media object, in bytes.</value>
    [DataMember(Name = "contentLengthBytes", EmitDefaultValue = false)]
    public long? ContentLengthBytes { get; set; }



    /// <summary>
    /// The optional name of the the media object.
    /// </summary>
    /// <value>The optional name of the the media object.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The optional id of the the media object.
    /// </summary>
    /// <value>The optional id of the the media object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicMessageMedia {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicMessageMedia);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicMessageMedia instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicMessageMedia to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicMessageMedia other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
