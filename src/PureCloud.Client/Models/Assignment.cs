using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Assignment
{
    /// <summary>
    /// The list of users successfully assigned to the custom performance profile
    /// </summary>
    /// <value>The list of users successfully assigned to the custom performance profile</value>
    public IEnumerable<UserReference> AssignedMembers { get; set; }

    /// <summary>
    /// The list of users successfully removed from the custom performance profile
    /// </summary>
    /// <value>The list of users successfully removed from the custom performance profile</value>
    public IEnumerable<UserReference> RemovedMembers { get; set; }

    /// <summary>
    /// The list of users failed assignment or removal for the custom performance profile
    /// </summary>
    /// <value>The list of users failed assignment or removal for the custom performance profile</value>
    public IEnumerable<AssignmentError> AssignmentErrors { get; set; }
}
