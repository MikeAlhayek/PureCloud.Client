using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Facet
/// </summary>

public partial class Facet : IEquatable<Facet>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Facet" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Facet() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Facet" /> class.
    /// </summary>
    /// <param name="Name">The name of the field on which to facet. (required).</param>
    /// <param name="Type">The type of the facet, DATE or STRING. (required).</param>
    public Facet(string Name = null, string Type = null)
    {
        this.Name = Name;
        this.Type = Type;

    }



    /// <summary>
    /// The name of the field on which to facet.
    /// </summary>
    /// <value>The name of the field on which to facet.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The type of the facet, DATE or STRING.
    /// </summary>
    /// <value>The type of the facet, DATE or STRING.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Facet {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as Facet);
    }

    /// <summary>
    /// Returns true if Facet instances are equal
    /// </summary>
    /// <param name="other">Instance of Facet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Facet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
