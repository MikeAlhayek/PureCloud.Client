using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditQueryEntity
/// </summary>

public partial class AuditQueryEntity : IEquatable<AuditQueryEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditQueryEntity" /> class.
    /// </summary>
    /// <param name="Name">Name of the Entity.</param>
    /// <param name="Actions">List of Actions.</param>
    public AuditQueryEntity(string Name = null, List<string> Actions = null)
    {
        this.Name = Name;
        this.Actions = Actions;

    }



    /// <summary>
    /// Name of the Entity
    /// </summary>
    /// <value>Name of the Entity</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// List of Actions
    /// </summary>
    /// <value>List of Actions</value>
    [JsonPropertyName("actions")]
    public List<string> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditQueryEntity {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as AuditQueryEntity);
    }

    /// <summary>
    /// Returns true if AuditQueryEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditQueryEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditQueryEntity other)
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
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
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

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
