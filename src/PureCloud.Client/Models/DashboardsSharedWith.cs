using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DashboardsSharedWith
{
    /// <summary>
    /// The list of user ids to share the dashboard with
    /// </summary>
    /// <value>The list of user ids to share the dashboard with</value>
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// The list of team ids to share the dashboard with
    /// </summary>
    /// <value>The list of team ids to share the dashboard with</value>
    public IEnumerable<string> TeamIds { get; set; }
}
