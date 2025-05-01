using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationEventTopicMessageMetadataContent
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicMessageMetadataContent : IEquatable<QueueConversationEventTopicMessageMetadataContent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicMessageMetadataContent" /> class.
    /// </summary>
    /// <param name="ContentType">Type of this content element..</param>
    /// <param name="SubType">Content subtype, if any.</param>
    public QueueConversationEventTopicMessageMetadataContent(string ContentType = null, string SubType = null)
    {
        this.ContentType = ContentType;
        this.SubType = SubType;

    }



    /// <summary>
    /// Type of this content element.
    /// </summary>
    /// <value>Type of this content element.</value>
    [DataMember(Name = "contentType", EmitDefaultValue = false)]
    public string ContentType { get; set; }



    /// <summary>
    /// Content subtype, if any
    /// </summary>
    /// <value>Content subtype, if any</value>
    [DataMember(Name = "subType", EmitDefaultValue = false)]
    public string SubType { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicMessageMetadataContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  SubType: ").Append(SubType).Append("\n");
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
        return Equals(obj as QueueConversationEventTopicMessageMetadataContent);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicMessageMetadataContent instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicMessageMetadataContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicMessageMetadataContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                SubType == other.SubType ||
                SubType != null &&
                SubType.Equals(other.SubType)
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
            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (SubType != null)
            {
                hash = hash * 59 + SubType.GetHashCode();
            }

            return hash;
        }
    }
}
