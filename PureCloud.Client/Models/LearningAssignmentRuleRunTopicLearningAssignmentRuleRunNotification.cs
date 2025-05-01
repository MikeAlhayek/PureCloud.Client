using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification
/// </summary>
[DataContract]
public partial class LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification : IEquatable<LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="Total">Total.</param>
    public LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification(List<LearningAssignmentRuleRunTopicLearningAssignmentsCreated> Entities = null, long? Total = null)
    {
        this.Entities = Entities;
        this.Total = Total;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<LearningAssignmentRuleRunTopicLearningAssignmentsCreated> Entities { get; set; }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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
        return Equals(obj as LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification);
    }

    /// <summary>
    /// Returns true if LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification other)
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
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
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

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            return hash;
        }
    }
}
