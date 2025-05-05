using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuthzSubject
/// </summary>

public partial class AuthzSubject : IEquatable<AuthzSubject>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthzSubject" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Grants">Grants.</param>
    /// <param name="Version">Version.</param>
    public AuthzSubject(string Name = null, List<AuthzGrant> Grants = null, int? Version = null)
    {
        this.Name = Name;
        this.Grants = Grants;
        this.Version = Version;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Grants
    /// </summary>
    [JsonPropertyName("grants")]
    public List<AuthzGrant> Grants { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuthzSubject {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Grants: ").Append(Grants).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as AuthzSubject);
    }

    /// <summary>
    /// Returns true if AuthzSubject instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthzSubject to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthzSubject other)
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
                Grants == other.Grants ||
                Grants != null &&
                Grants.SequenceEqual(other.Grants)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Grants != null)
            {
                hash = hash * 59 + Grants.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
