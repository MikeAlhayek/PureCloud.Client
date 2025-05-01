using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TransferInitiator
/// </summary>
[DataContract]
public partial class TransferInitiator : IEquatable<TransferInitiator>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransferInitiator" /> class.
    /// </summary>
    /// <param name="UserId">The id of the user who initiated the command if it was initiated by a user..</param>
    public TransferInitiator(string UserId = null)
    {
        this.UserId = UserId;

    }



    /// <summary>
    /// The id of the user who initiated the command if it was initiated by a user.
    /// </summary>
    /// <value>The id of the user who initiated the command if it was initiated by a user.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TransferInitiator {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as TransferInitiator);
    }

    /// <summary>
    /// Returns true if TransferInitiator instances are equal
    /// </summary>
    /// <param name="other">Instance of TransferInitiator to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransferInitiator other)
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

            return hash;
        }
    }
}
