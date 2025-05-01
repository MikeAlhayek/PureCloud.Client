using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserLicenses
/// </summary>
[DataContract]
public partial class UserLicenses : IEquatable<UserLicenses>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserLicenses" /> class.
    /// </summary>
    /// <param name="Licenses">Licenses.</param>
    public UserLicenses(List<string> Licenses = null)
    {
        this.Licenses = Licenses;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Licenses
    /// </summary>
    [DataMember(Name = "licenses", EmitDefaultValue = false)]
    public List<string> Licenses { get; set; }



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
        sb.Append("class UserLicenses {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Licenses: ").Append(Licenses).Append("\n");
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
        return Equals(obj as UserLicenses);
    }

    /// <summary>
    /// Returns true if UserLicenses instances are equal
    /// </summary>
    /// <param name="other">Instance of UserLicenses to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserLicenses other)
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
                Licenses == other.Licenses ||
                Licenses != null &&
                Licenses.SequenceEqual(other.Licenses)
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

            if (Licenses != null)
            {
                hash = hash * 59 + Licenses.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
