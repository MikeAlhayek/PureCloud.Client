using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EntityChange
/// </summary>

public partial class EntityChange : IEquatable<EntityChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityChange" /> class.
    /// </summary>
    /// <param name="EntityId">Id of the entity that was changed.</param>
    /// <param name="EntityName">Name of the entity that was changed.</param>
    /// <param name="EntityType">Type of the entity that was changed.</param>
    /// <param name="OldValues">Previous values for the entity..</param>
    /// <param name="NewValues">New values for the entity..</param>
    public EntityChange(string EntityId = null, string EntityName = null, string EntityType = null, List<string> OldValues = null, List<string> NewValues = null)
    {
        this.EntityId = EntityId;
        this.EntityName = EntityName;
        this.EntityType = EntityType;
        this.OldValues = OldValues;
        this.NewValues = NewValues;

    }



    /// <summary>
    /// Id of the entity that was changed
    /// </summary>
    /// <value>Id of the entity that was changed</value>
    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }



    /// <summary>
    /// Name of the entity that was changed
    /// </summary>
    /// <value>Name of the entity that was changed</value>
    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }



    /// <summary>
    /// Type of the entity that was changed
    /// </summary>
    /// <value>Type of the entity that was changed</value>
    [JsonPropertyName("entityType")]
    public string EntityType { get; set; }



    /// <summary>
    /// Previous values for the entity.
    /// </summary>
    /// <value>Previous values for the entity.</value>
    [JsonPropertyName("oldValues")]
    public List<string> OldValues { get; set; }



    /// <summary>
    /// New values for the entity.
    /// </summary>
    /// <value>New values for the entity.</value>
    [JsonPropertyName("newValues")]
    public List<string> NewValues { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EntityChange {\n");

        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  OldValues: ").Append(OldValues).Append("\n");
        sb.Append("  NewValues: ").Append(NewValues).Append("\n");
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
        return Equals(obj as EntityChange);
    }

    /// <summary>
    /// Returns true if EntityChange instances are equal
    /// </summary>
    /// <param name="other">Instance of EntityChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EntityChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EntityId == other.EntityId ||
                EntityId != null &&
                EntityId.Equals(other.EntityId)
            ) &&
            (
                EntityName == other.EntityName ||
                EntityName != null &&
                EntityName.Equals(other.EntityName)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                OldValues == other.OldValues ||
                OldValues != null &&
                OldValues.SequenceEqual(other.OldValues)
            ) &&
            (
                NewValues == other.NewValues ||
                NewValues != null &&
                NewValues.SequenceEqual(other.NewValues)
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
            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (OldValues != null)
            {
                hash = hash * 59 + OldValues.GetHashCode();
            }

            if (NewValues != null)
            {
                hash = hash * 59 + NewValues.GetHashCode();
            }

            return hash;
        }
    }
}
