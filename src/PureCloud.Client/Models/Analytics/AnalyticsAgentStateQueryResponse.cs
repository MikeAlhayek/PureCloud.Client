using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsAgentStateQueryResponse
{
    /// <summary>
    /// List of agents
    /// </summary>
    /// <value>List of agents</value>
    public IEnumerable<AnalyticsAgentStateAgentResponse> Entities { get; set; }
}
