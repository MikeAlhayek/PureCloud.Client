using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DependencyType
/// </summary>
[DataContract]
public partial class DependencyType : IEquatable<DependencyType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DependencyType" /> class.
    /// </summary>
    /// <param name="Id">The dependency type identifier.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Versioned">Versioned.</param>
    public DependencyType(string Id = null, string Name = null, bool? Versioned = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Versioned = Versioned;

    }



    /// <summary>
    /// The dependency type identifier
    /// </summary>
    /// <value>The dependency type identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Versioned
    /// </summary>
    [DataMember(Name = "versioned", EmitDefaultValue = false)]
    public bool? Versioned { get; set; }



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
        sb.Append("class DependencyType {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Versioned: ").Append(Versioned).Append("\n");
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
        return Equals(obj as DependencyType);
    }

    /// <summary>
    /// Returns true if DependencyType instances are equal
    /// </summary>
    /// <param name="other">Instance of DependencyType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DependencyType other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Versioned == other.Versioned ||
                Versioned != null &&
                Versioned.Equals(other.Versioned)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Versioned != null)
            {
                hash = hash * 59 + Versioned.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
