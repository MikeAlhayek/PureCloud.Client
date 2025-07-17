using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AssignmentError
{
    /// <summary>
    /// A user that is failed to be removed from the performance profile
    /// </summary>
    /// <value>A user that is failed to be removed from the performance profile</value>
    public UserReference User { get; set; }

    /// <summary>
    /// Error message from membership assignment
    /// </summary>
    /// <value>Error message from membership assignment</value>
    public string Message { get; set; }
}
