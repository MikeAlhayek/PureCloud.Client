using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationDivisionMembership
/// </summary>

public partial class ConversationDivisionMembership : IEquatable<ConversationDivisionMembership>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationDivisionMembership" /> class.
    /// </summary>
    /// <param name="Division">A division the conversation belongs to..</param>
    /// <param name="Entities">The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions..</param>
    public ConversationDivisionMembership(DomainEntityRef Division = null, List<DivisionEntityRef> Entities = null)
    {
        this.Division = Division;
        this.Entities = Entities;

    }



    /// <summary>
    /// A division the conversation belongs to.
    /// </summary>
    /// <value>A division the conversation belongs to.</value>
    [JsonPropertyName("division")]
    public DomainEntityRef Division { get; set; }



    /// <summary>
    /// The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.
    /// </summary>
    /// <value>The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.</value>
    [JsonPropertyName("entities")]
    public List<DivisionEntityRef> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationDivisionMembership {\n");

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
        return Equals(obj as ConversationDivisionMembership);
    }

    /// <summary>
    /// Returns true if ConversationDivisionMembership instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationDivisionMembership to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationDivisionMembership other)
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
