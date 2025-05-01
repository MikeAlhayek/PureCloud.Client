using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DeletableUserReference
/// </summary>
[DataContract]
public partial class DeletableUserReference : IEquatable<DeletableUserReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeletableUserReference" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Delete">If marked true, the user will be removed an associated entity.</param>
    public DeletableUserReference(string Id = null, bool? Delete = null)
    {
        this.Id = Id;
        this.Delete = Delete;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// If marked true, the user will be removed an associated entity
    /// </summary>
    /// <value>If marked true, the user will be removed an associated entity</value>
    [DataMember(Name = "delete", EmitDefaultValue = false)]
    public bool? Delete { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DeletableUserReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Delete: ").Append(Delete).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as DeletableUserReference);
    }

    /// <summary>
    /// Returns true if DeletableUserReference instances are equal
    /// </summary>
    /// <param name="other">Instance of DeletableUserReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DeletableUserReference other)
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
                Delete == other.Delete ||
                Delete != null &&
                Delete.Equals(other.Delete)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Delete != null)
            {
                hash = hash * 59 + Delete.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
