using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Fields identifying the destination of a given conversation command.
/// </summary>
[DataContract]
public partial class ConversationEventTopicTransferDestination : IEquatable<ConversationEventTopicTransferDestination>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventTopicTransferDestination" /> class.
    /// </summary>
    /// <param name="UserId">The id of the user if the command destination is a user..</param>
    /// <param name="Address">The destination address if the command destination is an endpoint..</param>
    public ConversationEventTopicTransferDestination(string UserId = null, string Address = null)
    {
        this.UserId = UserId;
        this.Address = Address;

    }



    /// <summary>
    /// The id of the user if the command destination is a user.
    /// </summary>
    /// <value>The id of the user if the command destination is a user.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// The destination address if the command destination is an endpoint.
    /// </summary>
    /// <value>The destination address if the command destination is an endpoint.</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventTopicTransferDestination {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(obj as ConversationEventTopicTransferDestination);
    }

    /// <summary>
    /// Returns true if ConversationEventTopicTransferDestination instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventTopicTransferDestination to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventTopicTransferDestination other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            return hash;
        }
    }
}
