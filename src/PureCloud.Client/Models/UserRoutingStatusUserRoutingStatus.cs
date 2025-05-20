using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserRoutingStatusUserRoutingStatus
{
    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    /// <value>The unique identifier of the user.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    public UserRoutingStatusRoutingStatus RoutingStatus { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public UserRoutingStatusErrorInfo ErrorInfo { get; set; }
}
