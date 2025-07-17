using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AssignmentValidation
{
    /// <summary>
    /// The list of users that are not assigned to any custom performance profile
    /// </summary>
    /// <value>The list of users that are not assigned to any custom performance profile</value>
    public IEnumerable<UserReference> MembersNotAssigned { get; set; }

    /// <summary>
    /// The list of users that are already assigned to the requesting custom performance profile
    /// </summary>
    /// <value>The list of users that are already assigned to the requesting custom performance profile</value>
    public IEnumerable<UserReference> MembersAlreadyAssigned { get; set; }

    /// <summary>
    /// The list of users that are already assigned to other custom performance profiles
    /// </summary>
    /// <value>The list of users that are already assigned to other custom performance profiles</value>
    public IEnumerable<OtherProfileAssignment> MembersAlreadyAssignedToOther { get; set; }

    /// <summary>
    /// The list of user id that are invalid for the gamfication service to handle
    /// </summary>
    /// <value>The list of user id that are invalid for the gamfication service to handle</value>
    public IEnumerable<InvalidAssignment> InvalidMemberAssignments { get; set; }
}
