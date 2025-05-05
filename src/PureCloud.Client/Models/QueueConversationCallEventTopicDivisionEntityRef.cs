using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallEventTopicDivisionEntityRef
/// </summary>

public partial class QueueConversationCallEventTopicDivisionEntityRef : IEquatable<QueueConversationCallEventTopicDivisionEntityRef>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicDivisionEntityRef" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="DateDivisionUpdated">The time the entity division was last updated..</param>
    public QueueConversationCallEventTopicDivisionEntityRef(string Id = null, string SelfUri = null, DateTime? DateDivisionUpdated = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.DateDivisionUpdated = DateDivisionUpdated;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The time the entity division was last updated.
    /// </summary>
    /// <value>The time the entity division was last updated.</value>
    [JsonPropertyName("dateDivisionUpdated")]
    public DateTime? DateDivisionUpdated { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallEventTopicDivisionEntityRef {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  DateDivisionUpdated: ").Append(DateDivisionUpdated).Append("\n");
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
        return Equals(obj as QueueConversationCallEventTopicDivisionEntityRef);
    }

    /// <summary>
    /// Returns true if QueueConversationCallEventTopicDivisionEntityRef instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallEventTopicDivisionEntityRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallEventTopicDivisionEntityRef other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                DateDivisionUpdated == other.DateDivisionUpdated ||
                DateDivisionUpdated != null &&
                DateDivisionUpdated.Equals(other.DateDivisionUpdated)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (DateDivisionUpdated != null)
            {
                hash = hash * 59 + DateDivisionUpdated.GetHashCode();
            }

            return hash;
        }
    }
}
