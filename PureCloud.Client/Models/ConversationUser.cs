using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationUser
/// </summary>
[DataContract]
public partial class ConversationUser : IEquatable<ConversationUser>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationUser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationUser" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for this user. (required).</param>
    public ConversationUser(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The globally unique identifier for this user.
    /// </summary>
    /// <value>The globally unique identifier for this user.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationUser {\n");

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
        return Equals(obj as ConversationUser);
    }

    /// <summary>
    /// Returns true if ConversationUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationUser other)
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

            return hash;
        }
    }
}
