using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityTypeBinding
/// </summary>

public partial class NamedEntityTypeBinding : IEquatable<NamedEntityTypeBinding>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeBinding" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityTypeBinding() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeBinding" /> class.
    /// </summary>
    /// <param name="EntityType">The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType. (required).</param>
    /// <param name="EntityName">The name that this named entity type is bound to. (required).</param>
    public NamedEntityTypeBinding(string EntityType = null, string EntityName = null)
    {
        this.EntityType = EntityType;
        this.EntityName = EntityName;

    }



    /// <summary>
    /// The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.
    /// </summary>
    /// <value>The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.</value>
    [JsonPropertyName("entityType")]
    public string EntityType { get; set; }



    /// <summary>
    /// The name that this named entity type is bound to.
    /// </summary>
    /// <value>The name that this named entity type is bound to.</value>
    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityTypeBinding {\n");

        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
        return Equals(obj as NamedEntityTypeBinding);
    }

    /// <summary>
    /// Returns true if NamedEntityTypeBinding instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityTypeBinding to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityTypeBinding other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                EntityName == other.EntityName ||
                EntityName != null &&
                EntityName.Equals(other.EntityName)
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
            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            return hash;
        }
    }
}
