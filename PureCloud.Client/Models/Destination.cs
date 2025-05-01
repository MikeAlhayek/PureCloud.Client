using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Destination
/// </summary>
[DataContract]
public partial class Destination : IEquatable<Destination>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Destination" /> class.
    /// </summary>
    /// <param name="Address">Address or phone number..</param>
    /// <param name="Name">The name of the internal user..</param>
    /// <param name="UserId">The user ID..</param>
    /// <param name="QueueId">The queue ID..</param>
    public Destination(string Address = null, string Name = null, string UserId = null, string QueueId = null)
    {
        this.Address = Address;
        this.Name = Name;
        this.UserId = UserId;
        this.QueueId = QueueId;

    }



    /// <summary>
    /// Address or phone number.
    /// </summary>
    /// <value>Address or phone number.</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }



    /// <summary>
    /// The name of the internal user.
    /// </summary>
    /// <value>The name of the internal user.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The user ID.
    /// </summary>
    /// <value>The user ID.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// The queue ID.
    /// </summary>
    /// <value>The queue ID.</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Destination {\n");

        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
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
        return Equals(obj as Destination);
    }

    /// <summary>
    /// Returns true if Destination instances are equal
    /// </summary>
    /// <param name="other">Instance of Destination to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Destination other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
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
            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            return hash;
        }
    }
}
