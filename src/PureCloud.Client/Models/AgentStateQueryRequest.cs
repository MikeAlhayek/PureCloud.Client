using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentStateQueryRequest
{
    /// <summary>
    /// Search user order dimension names; default to userName
    /// </summary>
    /// <value>Search user order dimension names; default to userName</value>
    public AgentStateQueryRequestUserOrderByEnum? UserOrderBy { get; set; }

    /// <summary>
    /// Search user order direction; default to asc
    /// </summary>
    /// <value>Search user order direction; default to asc</value>
    public AgentStateQueryRequestUserOrderEnum? UserOrder { get; set; }

    /// <summary>
    /// Search session order dimension names; default to segmentStart
    /// </summary>
    /// <value>Search session order dimension names; default to segmentStart</value>
    public AgentStateQueryRequestSessionOrderByEnum? SessionOrderBy { get; set; }

    /// <summary>
    /// Search session order direction; default to asc
    /// </summary>
    /// <value>Search session order direction; default to asc</value>
    public AgentStateQueryRequestSessionOrderEnum? SessionOrder { get; set; }

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
