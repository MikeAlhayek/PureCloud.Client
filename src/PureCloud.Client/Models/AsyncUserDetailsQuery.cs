using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AsyncUserDetailsQuery
{
    /// <summary>
    /// Sort the result set in ascending/descending order. Default is ascending
    /// </summary>
    /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
    public AsyncUserDetailsQueryOrderEnum? Order { get; set; }

    /// <summary>
    /// Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    public string Interval { get; set; }

    /// <summary>
    /// Filters that target the users to retrieve data for
    /// </summary>
    /// <value>Filters that target the users to retrieve data for</value>
    public IEnumerable<UserDetailQueryFilter> UserFilters { get; set; }

    /// <summary>
    /// Filters that target system and organization presence-level data
    /// </summary>
    /// <value>Filters that target system and organization presence-level data</value>
    public IEnumerable<PresenceDetailQueryFilter> PresenceFilters { get; set; }

    /// <summary>
    /// Filters that target agent routing status-level data
    /// </summary>
    /// <value>Filters that target agent routing status-level data</value>
    public IEnumerable<RoutingStatusDetailQueryFilter> RoutingStatusFilters { get; set; }

    /// <summary>
    /// Specify number of results to be returned
    /// </summary>
    /// <value>Specify number of results to be returned</value>
    public int? Limit { get; set; }
}
