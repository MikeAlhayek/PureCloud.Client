using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class UserExpands
{
    /// <summary>
    /// ACD routing status
    /// </summary>
    /// <value>ACD routing status</value>
    public RoutingStatus RoutingStatus { get; set; }

    /// <summary>
    /// Active presence
    /// </summary>
    /// <value>Active presence</value>
    public UserPresence Presence { get; set; }

    /// <summary>
    /// Active 3rd party presence
    /// </summary>
    /// <value>Active 3rd party presence</value>
    public UserPresence IntegrationPresence { get; set; }

    /// <summary>
    /// Summary of conversion statistics for conversation types.
    /// </summary>
    /// <value>Summary of conversion statistics for conversation types.</value>
    public UserConversationSummary ConversationSummary { get; set; }

    /// <summary>
    /// Determine if out of office is enabled
    /// </summary>
    /// <value>Determine if out of office is enabled</value>
    public OutOfOffice OutOfOffice { get; set; }

    /// <summary>
    /// Current geolocation position
    /// </summary>
    /// <value>Current geolocation position</value>
    public Geolocation Geolocation { get; set; }

    /// <summary>
    /// Effective, default, and last station information
    /// </summary>
    /// <value>Effective, default, and last station information</value>
    public UserStations Station { get; set; }

    /// <summary>
    /// Roles and permissions assigned to the user
    /// </summary>
    /// <value>Roles and permissions assigned to the user</value>
    public UserAuthorization Authorization { get; set; }
}
