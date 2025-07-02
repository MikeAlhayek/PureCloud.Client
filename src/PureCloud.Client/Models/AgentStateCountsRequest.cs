using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentStateCountsRequest
{
    /// <summary>
    /// Filters that target user-level data
    /// </summary>
    /// <value>Filters that target user-level data</value>
    public AgentStateUserFilter UserFilter { get; set; }

    /// <summary>
    /// Filters that target session-level data
    /// </summary>
    /// <value>Filters that target session-level data</value>
    public AgentStateSessionFilter SessionFilter { get; set; }
}
