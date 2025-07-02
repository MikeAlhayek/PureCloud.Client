using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationActivityQuery
{
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    public ConversationActivityQueryOrderEnum? Order { get; set; }

    /// <summary>
    /// List of requested metrics
    /// </summary>
    /// <value>List of requested metrics</value>
    public IEnumerable<ConversationActivityQueryMetric> Metrics { get; set; }

    /// <summary>
    /// Dimension(s) to group by
    /// </summary>
    /// <value>Dimension(s) to group by</value>
    public IEnumerable<ConversationActivityQueryGroupByEnum> GroupBy { get; set; }

    /// <summary>
    /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
    /// </summary>
    /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
    public ConversationActivityQueryFilter Filter { get; set; }
}
