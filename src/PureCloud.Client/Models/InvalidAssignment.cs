using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InvalidAssignment
{
    /// <summary>
    /// Invalid user for validation
    /// </summary>
    /// <value>Invalid user for validation</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The reason for the invalid input for validation
    /// </summary>
    /// <value>The reason for the invalid input for validation</value>
    public string Message { get; set; }
}
