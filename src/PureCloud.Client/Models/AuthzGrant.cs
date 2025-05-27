using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthzGrant
{
    /// <summary>
    /// Gets or Sets SubjectId
    /// </summary>
    public string SubjectId { get; set; }

    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public AuthzDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets Role
    /// </summary>
    public AuthzGrantRole Role { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? GrantMadeAt { get; set; }
}
