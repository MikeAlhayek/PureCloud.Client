using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityTypeDefinition
/// </summary>

public partial class NamedEntityTypeDefinition : IEquatable<NamedEntityTypeDefinition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityTypeDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeDefinition" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity type. (required).</param>
    /// <param name="Description">Description of the of the named entity type..</param>
    /// <param name="Mechanism">The mechanism enabling detection of the named entity type. (required).</param>
    public NamedEntityTypeDefinition(string Name = null, string Description = null, NamedEntityTypeMechanism Mechanism = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Mechanism = Mechanism;

    }



    /// <summary>
    /// The name of the entity type.
    /// </summary>
    /// <value>The name of the entity type.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Description of the of the named entity type.
    /// </summary>
    /// <value>Description of the of the named entity type.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The mechanism enabling detection of the named entity type.
    /// </summary>
    /// <value>The mechanism enabling detection of the named entity type.</value>
    [JsonPropertyName("mechanism")]
    public NamedEntityTypeMechanism Mechanism { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityTypeDefinition {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
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
        return Equals(obj as NamedEntityTypeDefinition);
    }

    /// <summary>
    /// Returns true if NamedEntityTypeDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityTypeDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityTypeDefinition other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Mechanism == other.Mechanism ||
                Mechanism != null &&
                Mechanism.Equals(other.Mechanism)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Mechanism != null)
            {
                hash = hash * 59 + Mechanism.GetHashCode();
            }

            return hash;
        }
    }
}
