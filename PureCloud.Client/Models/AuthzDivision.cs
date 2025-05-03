using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuthzDivision
/// </summary>

public partial class AuthzDivision : IEquatable<AuthzDivision>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthzDivision" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuthzDivision() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthzDivision" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">A helpful description for the division. (required).</param>
    public AuthzDivision(string Name = null, string Description = null)
    {
        this.Name = Name;
        this.Description = Description;

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
    /// A helpful description for the division.
    /// </summary>
    /// <value>A helpful description for the division.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.
    /// </summary>
    /// <value>A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.</value>
    [JsonPropertyName("homeDivision")]
    public bool? HomeDivision { get; private set; }



    /// <summary>
    /// A count of objects in this division, grouped by type.
    /// </summary>
    /// <value>A count of objects in this division, grouped by type.</value>
    [JsonPropertyName("objectCounts")]
    public Dictionary<string, long?> ObjectCounts { get; private set; }



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
        sb.Append("class AuthzDivision {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  HomeDivision: ").Append(HomeDivision).Append("\n");
        sb.Append("  ObjectCounts: ").Append(ObjectCounts).Append("\n");
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
        return Equals(obj as AuthzDivision);
    }

    /// <summary>
    /// Returns true if AuthzDivision instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthzDivision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthzDivision other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                HomeDivision == other.HomeDivision ||
                HomeDivision != null &&
                HomeDivision.Equals(other.HomeDivision)
            ) &&
            (
                ObjectCounts == other.ObjectCounts ||
                ObjectCounts != null &&
                ObjectCounts.SequenceEqual(other.ObjectCounts)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (HomeDivision != null)
            {
                hash = hash * 59 + HomeDivision.GetHashCode();
            }

            if (ObjectCounts != null)
            {
                hash = hash * 59 + ObjectCounts.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
