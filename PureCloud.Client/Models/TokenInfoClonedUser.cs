using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// TokenInfoClonedUser
/// </summary>
[DataContract]
public partial class TokenInfoClonedUser : IEquatable<TokenInfoClonedUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TokenInfoClonedUser" /> class.
    /// </summary>
    public TokenInfoClonedUser()
    {

    }



    /// <summary>
    /// User id of the original native user
    /// </summary>
    /// <value>User id of the original native user</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Organization of the original native user
    /// </summary>
    /// <value>Organization of the original native user</value>
    [DataMember(Name = "organization", EmitDefaultValue = false)]
    public Entity Organization { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TokenInfoClonedUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Organization: ").Append(Organization).Append("\n");
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
        return Equals(obj as TokenInfoClonedUser);
    }

    /// <summary>
    /// Returns true if TokenInfoClonedUser instances are equal
    /// </summary>
    /// <param name="other">Instance of TokenInfoClonedUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TokenInfoClonedUser other)
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
                Organization == other.Organization ||
                Organization != null &&
                Organization.Equals(other.Organization)
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

            if (Organization != null)
            {
                hash = hash * 59 + Organization.GetHashCode();
            }

            return hash;
        }
    }
}
