using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ReviewAssessmentResults
/// </summary>
[DataContract]
public partial class ReviewAssessmentResults : IEquatable<ReviewAssessmentResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReviewAssessmentResults" /> class.
    /// </summary>
    /// <param name="ByAssignees">If true, learning assignment results can be seen in detail by assignees.</param>
    /// <param name="ByViewers">If true, learning assignment results can be seen in detail by people who are eligible to view.</param>
    public ReviewAssessmentResults(bool? ByAssignees = null, bool? ByViewers = null)
    {
        this.ByAssignees = ByAssignees;
        this.ByViewers = ByViewers;

    }



    /// <summary>
    /// If true, learning assignment results can be seen in detail by assignees
    /// </summary>
    /// <value>If true, learning assignment results can be seen in detail by assignees</value>
    [DataMember(Name = "byAssignees", EmitDefaultValue = false)]
    public bool? ByAssignees { get; set; }



    /// <summary>
    /// If true, learning assignment results can be seen in detail by people who are eligible to view
    /// </summary>
    /// <value>If true, learning assignment results can be seen in detail by people who are eligible to view</value>
    [DataMember(Name = "byViewers", EmitDefaultValue = false)]
    public bool? ByViewers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReviewAssessmentResults {\n");

        sb.Append("  ByAssignees: ").Append(ByAssignees).Append("\n");
        sb.Append("  ByViewers: ").Append(ByViewers).Append("\n");
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
        return Equals(obj as ReviewAssessmentResults);
    }

    /// <summary>
    /// Returns true if ReviewAssessmentResults instances are equal
    /// </summary>
    /// <param name="other">Instance of ReviewAssessmentResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReviewAssessmentResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ByAssignees == other.ByAssignees ||
                ByAssignees != null &&
                ByAssignees.Equals(other.ByAssignees)
            ) &&
            (
                ByViewers == other.ByViewers ||
                ByViewers != null &&
                ByViewers.Equals(other.ByViewers)
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
            if (ByAssignees != null)
            {
                hash = hash * 59 + ByAssignees.GetHashCode();
            }

            if (ByViewers != null)
            {
                hash = hash * 59 + ByViewers.GetHashCode();
            }

            return hash;
        }
    }
}
