using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChangeMyPasswordRequest
{
    /// <summary>
    /// The new password
    /// </summary>
    /// <value>The new password</value>
    public string NewPassword { get; set; }

    /// <summary>
    /// Your current password
    /// </summary>
    /// <value>Your current password</value>
    public string OldPassword { get; set; }
}
