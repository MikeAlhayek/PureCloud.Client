using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectFlowNotificationUser
{
    /// <summary>
    /// The ID of the user.
    /// </summary>
    /// <value>The ID of the user.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the user, if available.
    /// </summary>
    /// <value>The name of the user, if available.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets HomeOrg
    /// </summary>
    public ArchitectFlowNotificationHomeOrganization HomeOrg { get; set; }
}
