using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationScreenShareEventTopicConversationDivisionMembership
/// </summary>

public partial class QueueConversationScreenShareEventTopicConversationDivisionMembership : IEquatable<QueueConversationScreenShareEventTopicConversationDivisionMembership>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationScreenShareEventTopicConversationDivisionMembership" /> class.
    /// </summary>
    /// <param name="Division">Division.</param>
    /// <param name="Entities">Entities.</param>
    public QueueConversationScreenShareEventTopicConversationDivisionMembership(QueueConversationScreenShareEventTopicDomainEntityRef Division = null, List<QueueConversationScreenShareEventTopicDivisionEntityRef> Entities = null)
    {
        this.Division = Division;
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [JsonPropertyName("division")]
    public QueueConversationScreenShareEventTopicDomainEntityRef Division { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<QueueConversationScreenShareEventTopicDivisionEntityRef> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationScreenShareEventTopicConversationDivisionMembership {\n");

        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as QueueConversationScreenShareEventTopicConversationDivisionMembership);
    }

    /// <summary>
    /// Returns true if QueueConversationScreenShareEventTopicConversationDivisionMembership instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationScreenShareEventTopicConversationDivisionMembership to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationScreenShareEventTopicConversationDivisionMembership other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
