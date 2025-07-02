using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentStateSessionFilter
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses</value>
    public AgentStateSessionFilterTypeEnum? Type { get; set; }

    /// <summary>
    /// Boolean &#39;and/or&#39; logic with up to two-levels of nesting
    /// </summary>
    /// <value>Boolean &#39;and/or&#39; logic with up to two-levels of nesting</value>
    public IEnumerable<AgentStateSessionQueryClause> Clauses { get; set; }

    /// <summary>
    /// Describes a &lt;dimension&gt; &#x3D; &lt;value&gt; filter used to perform matching
    /// </summary>
    /// <value>Describes a &lt;dimension&gt; &#x3D; &lt;value&gt; filter used to perform matching</value>
    public IEnumerable<AgentStateSessionQueryPredicate> Predicates { get; set; }
}
