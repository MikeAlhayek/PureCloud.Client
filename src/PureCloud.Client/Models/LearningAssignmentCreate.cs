using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentCreate
/// </summary>

public partial class LearningAssignmentCreate : IEquatable<LearningAssignmentCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningAssignmentCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
    /// </summary>
    /// <param name="ModuleId">The Learning module Id associated with this assignment (required).</param>
    /// <param name="UserId">The User for whom the assignment is assigned (required).</param>
    /// <param name="RecommendedCompletionDate">The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LengthInMinutes">The length in minutes of assignment.</param>
    public LearningAssignmentCreate(string ModuleId = null, string UserId = null, DateTime? RecommendedCompletionDate = null, int? LengthInMinutes = null)
    {
        this.ModuleId = ModuleId;
        this.UserId = UserId;
        this.RecommendedCompletionDate = RecommendedCompletionDate;
        this.LengthInMinutes = LengthInMinutes;

    }



    /// <summary>
    /// The Learning module Id associated with this assignment
    /// </summary>
    /// <value>The Learning module Id associated with this assignment</value>
    [JsonPropertyName("moduleId")]
    public string ModuleId { get; set; }



    /// <summary>
    /// The User for whom the assignment is assigned
    /// </summary>
    /// <value>The User for whom the assignment is assigned</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("recommendedCompletionDate")]
    public DateTime? RecommendedCompletionDate { get; set; }



    /// <summary>
    /// The length in minutes of assignment
    /// </summary>
    /// <value>The length in minutes of assignment</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentCreate {\n");

        sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  RecommendedCompletionDate: ").Append(RecommendedCompletionDate).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
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
        return Equals(obj as LearningAssignmentCreate);
    }

    /// <summary>
    /// Returns true if LearningAssignmentCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentCreate other)
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
            ) &&
            (
                RecommendedCompletionDate == other.RecommendedCompletionDate ||
                RecommendedCompletionDate != null &&
                RecommendedCompletionDate.Equals(other.RecommendedCompletionDate)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
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

            if (RecommendedCompletionDate != null)
            {
                hash = hash * 59 + RecommendedCompletionDate.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
