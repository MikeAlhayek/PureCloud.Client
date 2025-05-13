using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistfilterConfigChangeFilterClause
{
    /// <summary>
    /// Contact list filter type
    /// </summary>
    /// <value>Contact list filter type</value>
    public DialerContactlistfilterConfigChangeFilterClauseFilterTypeEnum? FilterType { get; set; }

    /// <summary>
    /// The list of predicates in that clause
    /// </summary>
    /// <value>The list of predicates in that clause</value>
    public IEnumerable<DialerContactlistfilterConfigChangeFilterPredicate> Predicates { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
