using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentReassign
/// </summary>
[DataContract]
public partial class LearningAssignmentReassign : IEquatable<LearningAssignmentReassign>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentReassign" /> class.
    /// </summary>
    /// <param name="RecommendedCompletionDate">The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LengthInMinutes">The length in minutes of assignment.</param>
    public LearningAssignmentReassign(DateTime? RecommendedCompletionDate = null, int? LengthInMinutes = null)
    {
        this.RecommendedCompletionDate = RecommendedCompletionDate;
        this.LengthInMinutes = LengthInMinutes;

    }



    /// <summary>
    /// The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "recommendedCompletionDate", EmitDefaultValue = false)]
    public DateTime? RecommendedCompletionDate { get; set; }



    /// <summary>
    /// The length in minutes of assignment
    /// </summary>
    /// <value>The length in minutes of assignment</value>
    [DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
    public int? LengthInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentReassign {\n");

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
        return Equals(obj as LearningAssignmentReassign);
    }

    /// <summary>
    /// Returns true if LearningAssignmentReassign instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentReassign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentReassign other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
