using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentStateAgentQueryClause
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates</value>
    public AgentStateAgentQueryClauseTypeEnum? Type { get; set; }

    /// <summary>
    /// Describes a &lt;dimension&gt; &#x3D; &lt;value&gt; filter used to perform matching
    /// </summary>
    /// <value>Describes a &lt;dimension&gt; &#x3D; &lt;value&gt; filter used to perform matching</value>
    public IEnumerable<AgentStateAgentQueryPredicate> Predicates { get; set; }
}
