using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentBulkAddResponse
/// </summary>

public partial class LearningAssignmentBulkAddResponse : IEquatable<LearningAssignmentBulkAddResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentBulkAddResponse" /> class.
    /// </summary>
    /// <param name="Entities">The learning assignments that were assigned correctly.</param>
    /// <param name="DisallowedEntities">The items that were not allowed to be assigned.</param>
    public LearningAssignmentBulkAddResponse(List<LearningAssignment> Entities = null, List<DisallowedEntityLearningAssignmentItem> DisallowedEntities = null)
    {
        this.Entities = Entities;
        this.DisallowedEntities = DisallowedEntities;

    }



    /// <summary>
    /// The learning assignments that were assigned correctly
    /// </summary>
    /// <value>The learning assignments that were assigned correctly</value>
    [JsonPropertyName("entities")]
    public List<LearningAssignment> Entities { get; set; }



    /// <summary>
    /// The items that were not allowed to be assigned
    /// </summary>
    /// <value>The items that were not allowed to be assigned</value>
    [JsonPropertyName("disallowedEntities")]
    public List<DisallowedEntityLearningAssignmentItem> DisallowedEntities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentBulkAddResponse {\n");

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
        return Equals(obj as LearningAssignmentBulkAddResponse);
    }

    /// <summary>
    /// Returns true if LearningAssignmentBulkAddResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentBulkAddResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentBulkAddResponse other)
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
