using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssignmentValidation
/// </summary>
[DataContract]
public partial class AssignmentValidation : IEquatable<AssignmentValidation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AssignmentValidation" /> class.
    /// </summary>
    /// <param name="MembersNotAssigned">The list of users that are not assigned to any custom performance profile.</param>
    /// <param name="MembersAlreadyAssigned">The list of users that are already assigned to the requesting custom performance profile.</param>
    /// <param name="MembersAlreadyAssignedToOther">The list of users that are already assigned to other custom performance profiles.</param>
    /// <param name="InvalidMemberAssignments">The list of user id that are invalid for the gamfication service to handle.</param>
    public AssignmentValidation(List<UserReference> MembersNotAssigned = null, List<UserReference> MembersAlreadyAssigned = null, List<OtherProfileAssignment> MembersAlreadyAssignedToOther = null, List<InvalidAssignment> InvalidMemberAssignments = null)
    {
        this.MembersNotAssigned = MembersNotAssigned;
        this.MembersAlreadyAssigned = MembersAlreadyAssigned;
        this.MembersAlreadyAssignedToOther = MembersAlreadyAssignedToOther;
        this.InvalidMemberAssignments = InvalidMemberAssignments;

    }



    /// <summary>
    /// The list of users that are not assigned to any custom performance profile
    /// </summary>
    /// <value>The list of users that are not assigned to any custom performance profile</value>
    [DataMember(Name = "membersNotAssigned", EmitDefaultValue = false)]
    public List<UserReference> MembersNotAssigned { get; set; }



    /// <summary>
    /// The list of users that are already assigned to the requesting custom performance profile
    /// </summary>
    /// <value>The list of users that are already assigned to the requesting custom performance profile</value>
    [DataMember(Name = "membersAlreadyAssigned", EmitDefaultValue = false)]
    public List<UserReference> MembersAlreadyAssigned { get; set; }



    /// <summary>
    /// The list of users that are already assigned to other custom performance profiles
    /// </summary>
    /// <value>The list of users that are already assigned to other custom performance profiles</value>
    [DataMember(Name = "membersAlreadyAssignedToOther", EmitDefaultValue = false)]
    public List<OtherProfileAssignment> MembersAlreadyAssignedToOther { get; set; }



    /// <summary>
    /// The list of user id that are invalid for the gamfication service to handle
    /// </summary>
    /// <value>The list of user id that are invalid for the gamfication service to handle</value>
    [DataMember(Name = "invalidMemberAssignments", EmitDefaultValue = false)]
    public List<InvalidAssignment> InvalidMemberAssignments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssignmentValidation {\n");

        sb.Append("  MembersNotAssigned: ").Append(MembersNotAssigned).Append("\n");
        sb.Append("  MembersAlreadyAssigned: ").Append(MembersAlreadyAssigned).Append("\n");
        sb.Append("  MembersAlreadyAssignedToOther: ").Append(MembersAlreadyAssignedToOther).Append("\n");
        sb.Append("  InvalidMemberAssignments: ").Append(InvalidMemberAssignments).Append("\n");
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
        return Equals(obj as AssignmentValidation);
    }

    /// <summary>
    /// Returns true if AssignmentValidation instances are equal
    /// </summary>
    /// <param name="other">Instance of AssignmentValidation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssignmentValidation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MembersNotAssigned == other.MembersNotAssigned ||
                MembersNotAssigned != null &&
                MembersNotAssigned.SequenceEqual(other.MembersNotAssigned)
            ) &&
            (
                MembersAlreadyAssigned == other.MembersAlreadyAssigned ||
                MembersAlreadyAssigned != null &&
                MembersAlreadyAssigned.SequenceEqual(other.MembersAlreadyAssigned)
            ) &&
            (
                MembersAlreadyAssignedToOther == other.MembersAlreadyAssignedToOther ||
                MembersAlreadyAssignedToOther != null &&
                MembersAlreadyAssignedToOther.SequenceEqual(other.MembersAlreadyAssignedToOther)
            ) &&
            (
                InvalidMemberAssignments == other.InvalidMemberAssignments ||
                InvalidMemberAssignments != null &&
                InvalidMemberAssignments.SequenceEqual(other.InvalidMemberAssignments)
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
            if (MembersNotAssigned != null)
            {
                hash = hash * 59 + MembersNotAssigned.GetHashCode();
            }

            if (MembersAlreadyAssigned != null)
            {
                hash = hash * 59 + MembersAlreadyAssigned.GetHashCode();
            }

            if (MembersAlreadyAssignedToOther != null)
            {
                hash = hash * 59 + MembersAlreadyAssignedToOther.GetHashCode();
            }

            if (InvalidMemberAssignments != null)
            {
                hash = hash * 59 + InvalidMemberAssignments.GetHashCode();
            }

            return hash;
        }
    }
}
