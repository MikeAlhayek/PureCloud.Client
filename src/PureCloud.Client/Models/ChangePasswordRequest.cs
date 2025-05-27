using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChangePasswordRequest
{
    /// <summary>
    /// The new password
    /// </summary>
    /// <value>The new password</value>
    public string NewPassword { get; set; }
}
