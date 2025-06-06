using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentItem
/// </summary>

public partial class LearningAssignmentItem : IEquatable<LearningAssignmentItem>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningAssignmentItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentItem" /> class.
    /// </summary>
    /// <param name="ModuleId">The Learning Module ID associated with this assignment (required).</param>
    /// <param name="UserId">The User ID associated with this assignment (required).</param>
    public LearningAssignmentItem(string ModuleId = null, string UserId = null)
    {
        this.ModuleId = ModuleId;
        this.UserId = UserId;

    }



    /// <summary>
    /// The Learning Module ID associated with this assignment
    /// </summary>
    /// <value>The Learning Module ID associated with this assignment</value>
    [JsonPropertyName("moduleId")]
    public string ModuleId { get; set; }



    /// <summary>
    /// The User ID associated with this assignment
    /// </summary>
    /// <value>The User ID associated with this assignment</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentItem {\n");

        sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as LearningAssignmentItem);
    }

    /// <summary>
    /// Returns true if LearningAssignmentItem instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ModuleId == other.ModuleId ||
                ModuleId != null &&
                ModuleId.Equals(other.ModuleId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
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
            if (ModuleId != null)
            {
                hash = hash * 59 + ModuleId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            return hash;
        }
    }
}
