using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMessageEventTopicConversationDivisionMembership
/// </summary>
[DataContract]
public partial class ConversationMessageEventTopicConversationDivisionMembership : IEquatable<ConversationMessageEventTopicConversationDivisionMembership>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageEventTopicConversationDivisionMembership" /> class.
    /// </summary>
    /// <param name="Division">Division.</param>
    /// <param name="Entities">Entities.</param>
    public ConversationMessageEventTopicConversationDivisionMembership(ConversationMessageEventTopicDomainEntityRef Division = null, List<ConversationMessageEventTopicDivisionEntityRef> Entities = null)
    {
        this.Division = Division;
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public ConversationMessageEventTopicDomainEntityRef Division { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<ConversationMessageEventTopicDivisionEntityRef> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageEventTopicConversationDivisionMembership {\n");

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
        return this.Equals(obj as ConversationMessageEventTopicConversationDivisionMembership);
    }

    /// <summary>
    /// Returns true if ConversationMessageEventTopicConversationDivisionMembership instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageEventTopicConversationDivisionMembership to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageEventTopicConversationDivisionMembership other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Division == other.Division ||
                this.Division != null &&
                this.Division.Equals(other.Division)
            ) &&
            (
                this.Entities == other.Entities ||
                this.Entities != null &&
                this.Entities.SequenceEqual(other.Entities)
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
            if (this.Division != null)
            {
                hash = hash * 59 + this.Division.GetHashCode();
            }

            if (this.Entities != null)
            {
                hash = hash * 59 + this.Entities.GetHashCode();
            }

            return hash;
        }
    }
}
