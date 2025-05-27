using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoleDivisionPair
{
    /// <summary>
    /// The ID of the role
    /// </summary>
    /// <value>The ID of the role</value>
    public string RoleId { get; set; }

    /// <summary>
    /// The ID of the division
    /// </summary>
    /// <value>The ID of the division</value>
    public string DivisionId { get; set; }
}
