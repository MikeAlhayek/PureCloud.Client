using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserProfile
{
    /// <summary>
    /// The state of the user resource
    /// </summary>
    /// <value>The state of the user resource</value>
    public UserProfileStateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Datetime of the last modification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Datetime of the last modification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The version of the group resource
    /// </summary>
    /// <value>The version of the group resource</value>
    public long? Version { get; set; }

    /// <summary>
    /// User information expansions
    /// </summary>
    /// <value>User information expansions</value>
    public UserExpands Expands { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
