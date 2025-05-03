using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DisallowedEntityLearningAssignmentItem
/// </summary>

public partial class DisallowedEntityLearningAssignmentItem : IEquatable<DisallowedEntityLearningAssignmentItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisallowedEntityLearningAssignmentItem" /> class.
    /// </summary>
    /// <param name="ErrorCode">The error code associated with this disallowed entity.</param>
    /// <param name="Entity">The entity that was disallowed.</param>
    public DisallowedEntityLearningAssignmentItem(string ErrorCode = null, LearningAssignmentItem Entity = null)
    {
        this.ErrorCode = ErrorCode;
        this.Entity = Entity;

    }



    /// <summary>
    /// The error code associated with this disallowed entity
    /// </summary>
    /// <value>The error code associated with this disallowed entity</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// The entity that was disallowed
    /// </summary>
    /// <value>The entity that was disallowed</value>
    [JsonPropertyName("entity")]
    public LearningAssignmentItem Entity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DisallowedEntityLearningAssignmentItem {\n");

        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
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
        return Equals(obj as DisallowedEntityLearningAssignmentItem);
    }

    /// <summary>
    /// Returns true if DisallowedEntityLearningAssignmentItem instances are equal
    /// </summary>
    /// <param name="other">Instance of DisallowedEntityLearningAssignmentItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DisallowedEntityLearningAssignmentItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
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
            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            return hash;
        }
    }
}
