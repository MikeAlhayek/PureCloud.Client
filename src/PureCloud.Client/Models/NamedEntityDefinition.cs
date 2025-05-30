using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityDefinition
/// </summary>

public partial class NamedEntityDefinition : IEquatable<NamedEntityDefinition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityDefinition" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Type">The name of the entity type. (required).</param>
    public NamedEntityDefinition(string Name = null, string Type = null)
    {
        this.Name = Name;
        this.Type = Type;

    }



    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The name of the entity type.
    /// </summary>
    /// <value>The name of the entity type.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityDefinition {\n");

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
        return Equals(obj as NamedEntityDefinition);
    }

    /// <summary>
    /// Returns true if NamedEntityDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityDefinition other)
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
