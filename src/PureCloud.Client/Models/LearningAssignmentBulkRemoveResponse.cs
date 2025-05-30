using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentBulkRemoveResponse
/// </summary>

public partial class LearningAssignmentBulkRemoveResponse : IEquatable<LearningAssignmentBulkRemoveResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentBulkRemoveResponse" /> class.
    /// </summary>
    /// <param name="Entities">The learning assignments that were removed successfully.</param>
    /// <param name="DisallowedEntities">The learning assignments that were not removed due to missing permissions.</param>
    public LearningAssignmentBulkRemoveResponse(List<LearningAssignmentEntity> Entities = null, List<DisallowedEntityLearningAssignmentReference> DisallowedEntities = null)
    {
        this.Entities = Entities;
        this.DisallowedEntities = DisallowedEntities;

    }



    /// <summary>
    /// The learning assignments that were removed successfully
    /// </summary>
    /// <value>The learning assignments that were removed successfully</value>
    [JsonPropertyName("entities")]
    public List<LearningAssignmentEntity> Entities { get; set; }



    /// <summary>
    /// The learning assignments that were not removed due to missing permissions
    /// </summary>
    /// <value>The learning assignments that were not removed due to missing permissions</value>
    [JsonPropertyName("disallowedEntities")]
    public List<DisallowedEntityLearningAssignmentReference> DisallowedEntities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentBulkRemoveResponse {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  DisallowedEntities: ").Append(DisallowedEntities).Append("\n");
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
        return Equals(obj as LearningAssignmentBulkRemoveResponse);
    }

    /// <summary>
    /// Returns true if LearningAssignmentBulkRemoveResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentBulkRemoveResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentBulkRemoveResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                DisallowedEntities == other.DisallowedEntities ||
                DisallowedEntities != null &&
                DisallowedEntities.SequenceEqual(other.DisallowedEntities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (DisallowedEntities != null)
            {
                hash = hash * 59 + DisallowedEntities.GetHashCode();
            }

            return hash;
        }
    }
}
