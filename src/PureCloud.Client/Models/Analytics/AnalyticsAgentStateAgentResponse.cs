using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsAgentStateAgentResponse
{
    /// <summary>
    /// User Id - only returned if division is covered by agentStateNames permission
    /// </summary>
    /// <value>User Id - only returned if division is covered by agentStateNames permission</value>
    public string UserId { get; set; }

    /// <summary>
    /// Division Id
    /// </summary>
    /// <value>Division Id</value>
    public string DivisionId { get; set; }

    /// <summary>
    /// User name - only returned if division is covered by agentStateNames permission
    /// </summary>
    /// <value>User name - only returned if division is covered by agentStateNames permission</value>
    public string UserName { get; set; }

    /// <summary>
    /// The user that this user reports to
    /// </summary>
    /// <value>The user that this user reports to</value>
    public string ManagerId { get; set; }

    /// <summary>
    /// The count of sessions
    /// </summary>
    /// <value>The count of sessions</value>
    public int? SessionCount { get; set; }

    /// <summary>
    /// List of sessions
    /// </summary>
    /// <value>List of sessions</value>
    public IEnumerable<AnalyticsAgentStateAgentSessionResult> Sessions { get; set; }
}
