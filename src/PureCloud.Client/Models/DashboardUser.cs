using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DashboardUser
{
    /// <summary>
    /// The state of the user
    /// </summary>
    /// <value>The state of the user</value>
    public DashboardUserStateEnum? State { get; set; }

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
    /// The count of dashboards for the user
    /// </summary>
    /// <value>The count of dashboards for the user</value>
    public int? DashboardCount { get; set; }

    /// <summary>
    /// The count of public dashboards for the user
    /// </summary>
    /// <value>The count of public dashboards for the user</value>
    public int? PublicDashboardCount { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
