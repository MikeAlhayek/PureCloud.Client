using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Assignment
/// </summary>

public partial class Assignment : IEquatable<Assignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Assignment" /> class.
    /// </summary>
    /// <param name="AssignedMembers">The list of users successfully assigned to the custom performance profile.</param>
    /// <param name="RemovedMembers">The list of users successfully removed from the custom performance profile.</param>
    /// <param name="AssignmentErrors">The list of users failed assignment or removal for the custom performance profile.</param>
    public Assignment(List<UserReference> AssignedMembers = null, List<UserReference> RemovedMembers = null, List<AssignmentError> AssignmentErrors = null)
    {
        this.AssignedMembers = AssignedMembers;
        this.RemovedMembers = RemovedMembers;
        this.AssignmentErrors = AssignmentErrors;

    }



    /// <summary>
    /// The list of users successfully assigned to the custom performance profile
    /// </summary>
    /// <value>The list of users successfully assigned to the custom performance profile</value>
    [JsonPropertyName("assignedMembers")]
    public List<UserReference> AssignedMembers { get; set; }



    /// <summary>
    /// The list of users successfully removed from the custom performance profile
    /// </summary>
    /// <value>The list of users successfully removed from the custom performance profile</value>
    [JsonPropertyName("removedMembers")]
    public List<UserReference> RemovedMembers { get; set; }



    /// <summary>
    /// The list of users failed assignment or removal for the custom performance profile
    /// </summary>
    /// <value>The list of users failed assignment or removal for the custom performance profile</value>
    [JsonPropertyName("assignmentErrors")]
    public List<AssignmentError> AssignmentErrors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Assignment {\n");

        sb.Append("  AssignedMembers: ").Append(AssignedMembers).Append("\n");
        sb.Append("  RemovedMembers: ").Append(RemovedMembers).Append("\n");
        sb.Append("  AssignmentErrors: ").Append(AssignmentErrors).Append("\n");
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
        return Equals(obj as Assignment);
    }

    /// <summary>
    /// Returns true if Assignment instances are equal
    /// </summary>
    /// <param name="other">Instance of Assignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Assignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AssignedMembers == other.AssignedMembers ||
                AssignedMembers != null &&
                AssignedMembers.SequenceEqual(other.AssignedMembers)
            ) &&
            (
                RemovedMembers == other.RemovedMembers ||
                RemovedMembers != null &&
                RemovedMembers.SequenceEqual(other.RemovedMembers)
            ) &&
            (
                AssignmentErrors == other.AssignmentErrors ||
                AssignmentErrors != null &&
                AssignmentErrors.SequenceEqual(other.AssignmentErrors)
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
            if (AssignedMembers != null)
            {
                hash = hash * 59 + AssignedMembers.GetHashCode();
            }

            if (RemovedMembers != null)
            {
                hash = hash * 59 + RemovedMembers.GetHashCode();
            }

            if (AssignmentErrors != null)
            {
                hash = hash * 59 + AssignmentErrors.GetHashCode();
            }

            return hash;
        }
    }
}
