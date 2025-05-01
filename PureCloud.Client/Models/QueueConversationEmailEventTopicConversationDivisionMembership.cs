using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationEmailEventTopicConversationDivisionMembership
/// </summary>
[DataContract]
public partial class QueueConversationEmailEventTopicConversationDivisionMembership : IEquatable<QueueConversationEmailEventTopicConversationDivisionMembership>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEmailEventTopicConversationDivisionMembership" /> class.
    /// </summary>
    /// <param name="Division">Division.</param>
    /// <param name="Entities">Entities.</param>
    public QueueConversationEmailEventTopicConversationDivisionMembership(QueueConversationEmailEventTopicDomainEntityRef Division = null, List<QueueConversationEmailEventTopicDivisionEntityRef> Entities = null)
    {
        this.Division = Division;
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public QueueConversationEmailEventTopicDomainEntityRef Division { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<QueueConversationEmailEventTopicDivisionEntityRef> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEmailEventTopicConversationDivisionMembership {\n");

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
        return Equals(obj as QueueConversationEmailEventTopicConversationDivisionMembership);
    }

    /// <summary>
    /// Returns true if QueueConversationEmailEventTopicConversationDivisionMembership instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEmailEventTopicConversationDivisionMembership to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEmailEventTopicConversationDivisionMembership other)
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
